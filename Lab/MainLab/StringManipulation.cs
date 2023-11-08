// Створюємо клас для обробки рядків
class StringManipulation
{
    // Метод, який замінює символи у рядку, починаючи з позиції startPosition
    public static string ReplaceOnesWithZerosAndZerosWithOnes(string input, int startPosition)
    {
        char[] charArray = input.ToCharArray();
        for (int i = startPosition; i < charArray.Length; i++)
        {
            if (charArray[i] == '0')
                charArray[i] = '1';
            else if (charArray[i] == '1')
                charArray[i] = '0';
        }
        return new string(charArray);
    }
}