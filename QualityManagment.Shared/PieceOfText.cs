using System;
using System.Collections.Generic;

namespace QualityManagement.Shared
{
    public static class PieceOfText
	{
		public static Dictionary<string, int> SearchForFragments(string sCurr)
		{
			var result = new Dictionary<string, int>();

			string sMain = string.Empty;
			int fullSpaceCounter = 0;

			for (int i = 0; i < sCurr.Length; ++i)
			{
				if (sCurr[i] == ' ' || sCurr[i] == '\n')
					++fullSpaceCounter;
				if (sCurr[i] == '.' || sCurr[i] == ',' ||sCurr[i] == '!'/**/ || sCurr[i] == '?' || sCurr[i] == ';' || sCurr[i] == ':' ||
					sCurr[i] == '(' || sCurr[i] == ')' || sCurr[i] == '/')
					continue;
				else
					sMain += sCurr[i];
			}
			sMain += '\n';
			++fullSpaceCounter;

			string pieceOfText = sMain;
			int localFullSpaceCounter = fullSpaceCounter;

			IList<string> fragmentVector = new List<string>();

			while (localFullSpaceCounter > 3)
			{
				int spaceСounter = 0;
				int currentSpaceCounter = 2;
				int indexFirstSpace = 0;

				for (int i = 0; i < pieceOfText.Length; ++i)
					if (pieceOfText[i] == ' ' || pieceOfText[i] == '\n')
					{
						indexFirstSpace = i;
						break;
					}

				while (currentSpaceCounter < fullSpaceCounter)
				{
					spaceСounter = 0;
					++currentSpaceCounter;
					string strFragment = "";

					for (int i = 0; i < pieceOfText.Length; ++i)
					{
						if (pieceOfText[i] == ' ' || pieceOfText[i] == '\n')
							++spaceСounter;

						if (spaceСounter == currentSpaceCounter)
						{
							int coeffSpace = indexFirstSpace;
							int repeatCounter = 0;

							while (coeffSpace < pieceOfText.Length - 1)
							{
								string currentStr = "";
								spaceСounter = 0;

								for (int j = coeffSpace + 1; j < pieceOfText.Length; ++j)
								{

									if (pieceOfText[j] == ' ' || pieceOfText[j] == '\n')
										++spaceСounter;

									if (spaceСounter == currentSpaceCounter)
									{
										if (currentStr == strFragment)
										{
											++repeatCounter; //=0
										}
										break;
									}
									else
									{
										currentStr += pieceOfText[j];
									}
								}

								for (int j = coeffSpace + 1; j < pieceOfText.Length; ++j)
									if (pieceOfText[j] == ' ' || pieceOfText[j] == '\n')
									{
										coeffSpace = j;
										break;
									}
							}

							if (repeatCounter != 0)
							{
								bool flag = false;
								foreach (string s in fragmentVector)
									if (s == strFragment)
									{
										flag = true;
										break;
									}

								if (!flag)
								{
									fragmentVector.Add(strFragment);
									result.Add(strFragment, repeatCounter + 1);
								}
							}
							break;
						}
						else
						{
							strFragment += pieceOfText[i];
						}
					}
				}

				int currentFirstSpace = 0;

				for (int i = 0; i < pieceOfText.Length; ++i)
					if (pieceOfText[i] == ' ' || pieceOfText[i] == '\n')
					{
						currentFirstSpace = i;
						break;
					}

				string str = string.Empty;
				for (int i = currentFirstSpace + 1; i < pieceOfText.Length; ++i)
				{
					str += pieceOfText[i];
				}

				pieceOfText = str;
				--localFullSpaceCounter;
			}
			//result.Add("a d s s", 3);
			return result;
		}

	}
}
