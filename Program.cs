int number = 4567775;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
int[] digit = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};


foreach (char i in letters)
  {
      digit[i - '0']++;
  }
    
for (int j = 0;j < 10;j++)
  { 
    Console.WriteLine(j + " => " + digit[j]);
  }