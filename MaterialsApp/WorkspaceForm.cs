using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialsApp
{
    public partial class WorkspaceForm : Form
    {
        public WorkspaceForm(string segType, string segName, int segID, bool isNew = true)
        {
            InitializeComponent();
            Globals.segmentType = segType;

            if (!isNew)
            {
                // Populate the data grid with existing data associated with the ID. 
            }
        }

        private void WorkspaceForm_Load(object sender, EventArgs e)
        {
            var comboPop = new List<Enum>();
            /*
            The following dictionary related statement was suggested to me by the members of the unofficial C# discord.
            I asked for a more graceful way of handling a switch statement that looked like shit and they gave me this.
            This seems far too complicated for what I am hoping to achieve.
            */
            Dictionary<string, Type> mappings =
                new()
                {
                    ["Wall"] = typeof(WallSegment.WallItem),
                    ["Floor"] = typeof(FloorSegment.FloorItem),
                    ["Opening"] = typeof(OpeningSegment.OpeningItem),
                    ["Roof"] = typeof(RoofSegment.RoofItem)
                };
            if (mappings.TryGetValue(Globals.segmentType, out Type enumType))
            {
                comboPop.AddRange(Enum.GetValues(enumType).Cast<Enum>());
            }
            comboPop.AddRange(Enum.GetValues(typeof(SegmentItemEntry.CommonItems)).Cast<Enum>());
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
        }
    }
    public static class Globals
    {
        public static string segmentType;
    }
    public class SegmentItemEntry
    {
        public enum GenericWoodMaterials
        {
            Redwood,
            [Display(Name = "Red cedar")]
            RedCedar,
            Cedar,
            Pine,
            Fir,
            Spruce,
            Cypress,
            Plywood
        }
        public enum GenericStoneMaterials
        {
            Marble,
            Granite,
            Slate,
            Sandstone,
            Limestone,
        }
        public enum CommonItems
        {
            Nails, // galvanized steel
            Screws, // galvanized steel
            Caulk, // caulk
            [Display(Name = "Joint compound")]
            JointCompound, // custom entry only
            [Display(Name = "Anchor bolt")]
            AnchorBolt, // steel
            Rebar, // steel
            Paint, // custom entry only
        }
    }

    public class WallSegment : SegmentItemEntry
    {
        public enum WallItem
        {
            Stud, // wood
            [Display(Name = "Stud block")]
            StudBlock, // wood
            [Display(Name = "Siding panel")]
            SidingPanel, // custom mats
            [Display(Name = "Log siding")]
            LogSiding, // wood
            [Display(Name = "Clapboard siding")]
            ClapboardSiding, // wood
            [Display(Name = "Drywall panel")]
            DrywallPanel,
            [Display(Name = "Foam board panel")]
            FoamBoardPanel,
            [Display(Name = "Concrete block")]
            ConcreteBlock,
            [Display(Name = "Reinforced concrete")]
            ReinforcedConcrete,
            Brick,
            [Display(Name = "Natural stone")]
            NaturalStone, // wood
            Insulation, // custom mats
        }
        public enum SidingPanelMats
        {
            Plasterboard,
            Vinyl,
            Aluminum,
            Steel,
            Plywood,
        }
        public enum InsulationMats
        {
            Fiberglass,
            Mineral,
            Concrete,
            [Display(Name = "Rigid foam")]
            RigidFoam,
            Cellulose,
            [Display(Name = "Spray-in foam")]
            SprayInFoam,

        }
    }

    public class FloorSegment : SegmentItemEntry
    {
        public enum FloorItem
        {
            Foundation, // custom mats
            Stone, // stone
            Hardwood, // wood
            Vinyl,
            Tile, // custom mats
        }
        public enum FoundationMats
        {
            Basement,
            Crawlspace,
            [Display(Name = "Concrete slab")]
            ConcreteSlab,
            Wood,
            Beam,
        }
        public enum TileMats
        {
            Ceramic,
            Porcelain,
            Marble,
        }
    }

    public class RoofSegment : SegmentItemEntry
    {
        public enum RoofItem
        {
            [Display(Name = "Clay roof tile")]
            ClayRoofTile,
            [Display(Name = "Slate roof tile")]
            SlateRoofTile,
            [Display(Name = "Wood roof tile")]
            WoodRoofTile, // wood
            [Display(Name = "Asphalt shingle")]
            AsphaltShingle,
            [Display(Name = "Metal roof")]
            MetalRoof, // custom mats
            Rafter, // custom mats
        }
        public enum MetalRoofMats
        {
            [Display(Name = "Galvanized steel")]
            GalvanizedSteel,
            Aluminum,
            [Display(Name = "Copper and zinc")]
            CopperAndZinc,
        }
        public enum RafterMats
        {
            Steel, // The generic wood list is attached to this.
        }
    }

    public class OpeningSegment : SegmentItemEntry
    {
        public enum OpeningItem
        {
            Door, // custom mats
            [Display(Name = "Door frame")]
            DoorFrame, // custom mats
            Header, // wood
            Weatherstrip, // vinyl
            [Display(Name = "Window glass")]
            WindowGlass, // glass
            [Display(Name = "Window frame")]
            WindowFrame, // custom mats
        }
        public enum OpeningCustomMats // Door, DoorFrame, and WindowFrame all use the same exact materials list, so I condensed them into one enum. 
        {
            Fiberglass,
            Aluminum,
            Vinyl, // The generic wood list is attached to this.
        }
    }
}
