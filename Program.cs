using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using IO_Project.Core;
using IO_Project.Core.JournalModifiers;
using IO_Project.Core.QueryExecutors;
using IO_Project.IO;
using IO_Project.IO.Entities;
using IO_Project.JourneyInteraction;
using IO_Project.JourneyInteraction.Entities;
using IO_Project.Panels;
using IO_Project.ParticipantInteraction;
using IO_Project.ParticipantInteraction.Entities;
using IO_Project.StageInteraction;
using IO_Project.StageInteraction.Entities;

namespace IO_Project
{
    static class Program
    {
        private static SqlConnection connection;
        private static Journal journal;
        private static RequestInteractor requestInteractor;
        private static StageInteractor stageInteractor;
        private static JourneyInteractor journeyInteractor;
        private static ParticipantInteractor participantInteractor;
        private static DataSynchronizer dataSynchronizer;
        private static AddNewPart addStageView;
        private static AddParticipant addParticipantView;
        private static ModifyJourney modifyJourneyView;
        private static JourneyView journeyView;
        private static JournalView journalView;
        private static AddJourney addJourneyView;
        private static CreateJourneyConfigurationProvider createJourneyConfigurationProvider;

        [STAThread]
        static void Main()
        {
            Initialize();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
         //   Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(journalView);
        }

        private static void Initialize()
        {
            InitializeDataOperators();
            CreateInteractors();
            CreateViews();
            CreateQueryExecutors();
            CreateJournalModifiers();
            CreateRequestConfigurationProviders();
        }

        private static void InitializeDataOperators()
        {
            connection =
                new SqlConnection(@"Data Source=DESKTOP-B6D6O41;Initial Catalog=IO_proj1;Integrated Security=True;Pooling=False");
            journal = new DatabaseInteractor(connection).LoadJournal();
            dataSynchronizer = new DataSynchronizer();
        }

        private static void CreateInteractors()
        {
            requestInteractor = new RequestInteractor(dataSynchronizer);
            stageInteractor = new StageInteractor(requestInteractor);
            journeyInteractor = new JourneyInteractor(requestInteractor);
            participantInteractor = new ParticipantInteractor(requestInteractor);
        }

        private static void CreateViews()
        {
            //    throw new NotImplementedException();
            
            addStageView = new AddNewPart(stageInteractor);
            journeyView = new JourneyView(journeyInteractor, stageInteractor);
            addParticipantView = new AddParticipant(participantInteractor);
            modifyJourneyView = new ModifyJourney(journeyInteractor);
            addJourneyView = new AddJourney(journeyInteractor);
            journalView = new JournalView(journal);
        }

        private static void CreateQueryExecutors()
        {
            RegisterQueryExecutor(new JourneyCreationQueryExecutor(connection));
            RegisterQueryExecutor(new JourneyModificationQueryExecutor(connection));
            RegisterQueryExecutor(new ParticipantAssignmentQueryExecutor(connection));
            RegisterQueryExecutor(new ParticipantCreationQueryExecutor(connection));
            RegisterQueryExecutor(new StageAssignmentQueryExecutor(connection));
            RegisterQueryExecutor(new StageModificationQueryExecutor(connection));
        }

        private static void CreateJournalModifiers()
        {
            RegisterJournalModifier(new JourneyCreator(journal));
            RegisterJournalModifier(new JourneyModifier(journal));
            RegisterJournalModifier(new ParticipantAssigner(journal));
            RegisterJournalModifier(new ParticipantCreator(journal));
            RegisterJournalModifier(new StageAssigner(journal));
            RegisterJournalModifier(new StageModifier(journal));
        }

        private static void CreateRequestConfigurationProviders()
        {
            RegisterRequestConfigurationProvider(new AssignParticipantConfigurationProvider(null, null));
            RegisterRequestConfigurationProvider(new AssignStageConfigurationProvider(null, null));
            RegisterRequestConfigurationProvider(new CreateJourneyConfigurationProvider(addJourneyView));
            RegisterRequestConfigurationProvider(new CreateParticipantConfigurationProvider(null));
            RegisterRequestConfigurationProvider(new ModifyJourneyConfigurationProvider(null, null));
            RegisterRequestConfigurationProvider(new ModifyStageConfigurationProvider(null, null, null));
        }

        private static void RegisterQueryExecutor(IQueryExecutor queryExecutor)
        {
            QueryExecutorsFactory.RegisterQueryExecutor(queryExecutor);
        }

        private static void RegisterJournalModifier(IJournalModifier journalModifier)
        {
            JournalModifiersFactory.RegisterJournalModifier(journalModifier);
        }

        private static void RegisterRequestConfigurationProvider(IRequestConfigurationProvider configurationProvider)
        {
            RequestConfigurationProvidersFactory.RegisterConfigurationProvider(configurationProvider);
        }
    }
}
