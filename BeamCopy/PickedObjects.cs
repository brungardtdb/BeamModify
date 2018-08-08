using System.Windows.Forms;
// Tekla Structures Namespace References
using Tekla.Structures.Model;
using T3D = Tekla.Structures.Geometry3d;
using TSMUI = Tekla.Structures.Model.UI;

namespace BeamCopy
{
    class PickedObjects
    {

        // fields for class
        private string channelProfile;
        private string channelClass;
        private Model thisModel;

        // properties for class
        public string ChannelProfile {
            get
            {
                return this.channelProfile;
            }
            set
            {
                this.channelProfile = value;
            }
        }
        public string ChannelClass
        {
            get
            {
                return this.channelClass;
            } 
            set
            {
                channelClass = value;
            }

        }
        public Model ThisModel
        {
            get
            {
                return this.thisModel;
            }
            set
            {
                this.thisModel = value;
            }
        }

        public PickedObjects(string channelProfile, string channelClass, Model Model)
        {
            Model ThisModel = Model;

            this.ChannelProfile = channelProfile;
            this.ChannelClass = channelClass;

            // User interface for the model, new picker for the user
            TSMUI.Picker Picker = new TSMUI.Picker();

            do
            {
                try
                {
                    // User picks one single object for input
                    Beam ThisBeam = Picker.PickObject(Tekla.Structures.Model.UI.Picker.PickObjectEnum.PICK_ONE_PART) as Beam; // Cast to beam

                    // If beam is not null
                    if (ThisBeam != null)
                    {
                        // Change channel profile to value passed in constructor
                        ThisBeam.Profile.ProfileString = this.ChannelProfile;
                        // Set class to value passed in constructor
                        ThisBeam.Class = this.ChannelClass;
                        // Move beam from origin, start point at 1000mm on x-axis
                        ThisBeam.StartPoint = new T3D.Point(0, 1000, 0);
                        // Move beam from origin, end point at 4000mm on x-axis and 1000mm on y-axis
                        ThisBeam.EndPoint = new T3D.Point(4000, 1000, 0);
                        // Method to modify beam and apply changes
                        ThisBeam.Modify();

                        // drawing changes and setting the undo
                        // Since user is selecting beam, we want change to be made right away
                        ThisModel.CommitChanges();
                    }
                }
                catch
                {

                    MessageBox.Show("Nothing was selected");

                }

            } while (Picker == null);
        }
    }
}
