using CryEngine;

namespace CryGameCode
{
    [FlowNode(UICategory = "Samples", Category = FlowNodeCategory.Approved, Description = "Does awesome CryMono things")]
    public class SampleNode : FlowNode
    {
		public enum MyEnum
		{
			First = 0,
			Second = 10,
			Third = 30
		}

		[Port(Name = "Int Enum")]
		public void IntEnum(MyEnum value) { }

        [Port(Name = "Activate", Description = "Test of a void input")]
        public void OnActivateTriggered()
        {
            Debug.Log("The activate port was triggered.");

            activatedPortId.Activate();
        }

		[Port(Name = "Test Int", Description = "Test of an int input")]
		public void OnIntTriggered(int value)
		{
			Debug.Log("The int port was triggered, value is {0}", value.ToString());

			testIntPortId.Activate(value);
		}

		[Port(Name = "Activated", Description = "")]
		public OutputPort activatedPortId { get; set; }

        [Port(Name = "Test Int", Description = "")]
		public OutputPort<int> testIntPortId { get; set; }
    }
}