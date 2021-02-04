using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Project.Panels
{
    public interface IPanelToggle
    {
        event Action<PanelType> OnToggleRequired;
    }
}
