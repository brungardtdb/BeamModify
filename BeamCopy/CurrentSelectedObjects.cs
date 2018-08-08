// Tekla Structures Namespace References
using Tekla.Structures.Model;
using T3D = Tekla.Structures.Geometry3d;
using TSMUI = Tekla.Structures.Model.UI;

namespace BeamCopy
{
    public class CurrentSelectedObjects
    {
        // fields for class
        private string channelProfile;
        private string channelClass;
        private Model thisModel;

        // properties for class
        public string ChannelProfile { get; set; }
        public string ChannelClass { get; set; }
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



        public CurrentSelectedObjects(string channelProfile, string channelClass, Model Model)
        {
            Model ThisModel = Model;

            //User interface for the model
            TSMUI.ModelObjectSelector GetSelectedObjects = new TSMUI.ModelObjectSelector();

            // Model Object Enumerator (from Tekla.Structures.Model namespace) collection of selected objects
            ModelObjectEnumerator SelectedObjects = GetSelectedObjects.GetSelectedObjects();

            // Change channel profile to value passed in constructor
            ChannelProfile = channelProfile;
            // Set class to value passed in constructor
            ChannelClass = channelClass;

            // go through objects in model objects enumerator MoveNext returns false at end of collection
            while (SelectedObjects.MoveNext())
            {
                // cast as beam, model 'object' class is just an abstract class, we must call out beams specifically.
                Beam ThisBeam = SelectedObjects.Current as Beam;
                if (ThisBeam != null)
                {
                    // Pass profile and class for beam from constructor
                    ThisBeam.Profile.ProfileString = ChannelProfile;
                    ThisBeam.Class = ChannelClass;
                    //Apply new start point and end point
                    ThisBeam.StartPoint = new T3D.Point(1000, 0, 0);
                    ThisBeam.EndPoint = new T3D.Point(4000, 1000, 0);

                   // Method to modify beam and apply changes
                   ThisBeam.Modify();
                }               
            }            
        }
    }
}

