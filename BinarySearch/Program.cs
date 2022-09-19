using LinkedListProblem1.DsAndAlgorithm;

const string WORDS_FILE_PATH = @"D:\RFP\DsAndAlgorithm\Words.txt";
while (true)
{
    Console.WriteLine("\n Select Program\n 1.Search");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            BinarySearch binarySearch = new BinarySearch();
            binarySearch.Search(WORDS_FILE_PATH);
            break;
    }
}
