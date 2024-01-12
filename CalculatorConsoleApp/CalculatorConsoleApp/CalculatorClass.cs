namespace CalculatorConsoleApp
{
    public class CalculatorClass
	{
		public CalculatorClass()
		{
		}

		public string Calculate(string str)
		{
			return this.ShuntingYardMethod(str);
			
		}


		private string ShuntingYardMethod(string str)
		{
			bool HaveOperatorToRead = true;

			int index = 0;
			string[] characters = str.Split();
			bool isNumber = false;
            var VarStack = new List<String>();
            var VarStackTemp = new List<String>();

            for (int i = 0; i < str.Length; i++)
			{
                isNumber = int.TryParse(str.Substring(i,1), out index);
                if (isNumber)
                {
                    VarStack.Add(str.Substring(i, 1));
					//i++;
				}
				else
				{
					if (VarStackTemp.Count > 0)
					{
						VarStack.Add(VarStackTemp[0]);
						VarStackTemp.Clear();
						VarStackTemp.Add(str.Substring(i, 1));
					}
					else
					{
                        VarStackTemp.Add(str.Substring(i, 1));
                    }
					
				}
            }

            /*
			foreach (var character in characters)
			{
				int i = 0;
				isNumber = int.TryParse(character, out i);
				if (isNumber)
				{
					VarStack[index] = character;
					index++;
				} 
			}
			*/

			return string.Join("", VarStack);
			/*
			string[] VarStack = new string[str.Length];
            string[] VarStackTemp = new string[str.Length];

            while (HaveOperatorToRead)
			{
				if (str.)
				HaveOperatorToRead = true;
			}
			*/
		}
	}
}

