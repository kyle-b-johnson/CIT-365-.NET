using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Johnson
{
    enum DesktopMaterial 
    {
        Pine,
        Laminate,
        Veneer,
        Oak,
        Rosewood
    };

    // This class will define the attributes of the desk object with width,
    // depth, number of drawers, and the surface material.

    class Desk
    {
        const decimal MIN_WIDTH = 24;
        const decimal MAX_WIDTH = 96;
        const decimal MIN_DEPTH = 12;
        const decimal MAX_DEPTH = 48;

        decimal width;
        decimal depth;
        int drawerNum;
        DesktopMaterial desktop;


    }
}
