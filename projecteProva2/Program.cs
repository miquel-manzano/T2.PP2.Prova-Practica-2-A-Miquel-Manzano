public class Program
{
    public static void Main(string[] args)
    {
        const int LeftArrayLimit = 0;
        const int RightArrayLimit = 7;
        const int SearchedNum = 10;
        int resultat;

        int[] ValidNumList = { 10, 4, 6, 4, 8, -13, 2, 3 };
        ArraySearch.SortArray.Order(ValidNumList, LeftArrayLimit, RightArrayLimit);
        resultat = ArraySearch.SearchNumArray.BinarySearch(ValidNumList, LeftArrayLimit, RightArrayLimit, SearchedNum) + 1;
        Console.WriteLine($"El numero {SearchedNum} es a la posicio: {resultat} sense contar el 0.");
    }
}

/*demani un valor enter a l'usuari per teclat i aquest retorni si es troba o no a la llista següent:
 { 10, 4, 6, 4, 8, -13, 2, 3} (1,5 punts)*/