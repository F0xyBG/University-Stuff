using System.Threading.Tasks.Sources;

namespace INormalVsVirtualMethods
{
    class BaseClassV
    {
        protected Dictionary<string, Action> vmt;

        public BaseClassV()
        {
            vmt = new Dictionary<string, Action>();
            vmt.Add("MV", MV);
        }

        public void MV()
        {
            Console.WriteLine("BaseClassV.MV");
        }

        public void Invoke(string methodName)
        {
            Action m = vmt[methodName];
            m();
        }
    }

    class DerivedClassV : BaseClassV
    {
        public void MV() { Console.WriteLine("DerivedClassV.MV"); }
        public DerivedClassV()
        {
            vmt["MV"] = MV;
        }
    }
}
