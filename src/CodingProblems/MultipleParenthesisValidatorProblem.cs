using System.Collections.Generic;

namespace CodingProblems
{
    public class MultipleParenthesisValidatorProblem
    {
        public bool IsValid(char[] input)
        {
            Dictionary<char, char> fastLookup = new();
            fastLookup.Add(')', '(');
            fastLookup.Add('}', '{');
            fastLookup.Add(']', '[');

            Stack<char> opened = new();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    opened.Push(input[i]);
                }
                else if (input[i] == ')' || input[i] == '}' || input[i] == ']')
                {
                    if (opened.Count == 0)
                    {
                        return false;
                    }
                    char candidateToClose = fastLookup[input[i]];
                    char lastOpened = opened.Pop();

                    if (candidateToClose != lastOpened)
                    {
                        return false;
                    }
                }
            }
            return opened.Count == 0;
        }
    }
}