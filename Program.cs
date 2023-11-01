internal class MyProgram
{
    static void StudentsGrades(int studentsNum, int subjectsNum)
    {
        string[,] students = new string[studentsNum, subjectsNum];
        for(int i = 0; i < studentsNum; i++)
        {
            for(int j = 0; j < subjectsNum; j++)
            {
                if(i == 0 && j == 0)
                {
                    students[i, j] = " ";
                }
                else if (i == 0 && j > 0)
                {
                    Console.WriteLine("Enter students' subjects");
                    students[i, j] = Console.ReadLine();
                }
                else if(i > 0 && j == 0)
                {
                    Console.WriteLine("Enter student's name");
                    students[i, j] = Console.ReadLine();
                }
                else{
                    Console.WriteLine("Enter student's score");
                    students[i, j] = Console.ReadLine();
                }
            }
        }
        
        for(int i = 0; i < students.GetLength(0); i++) { 
            for(int j = 0; j < students.GetLength(1); j++)
            {
                //if (j == students.GetLength(1) - 1)
                //{
                //    Console.Write(students[i, j] + "\n");
                //}
                //else
                //{
                //    Console.Write(students[i, j] + "\t");
                //}
                Console.Write(students[i, j] + "\t");
                if(j == i - 1)
                {
                    Console.Write("\n");
                }
            }
        }
    }

    static int[,] transposeArray(int[,] arr)
    {
        int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
        for(int i = 0; i < arr.GetLength(0); i++)
        {

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                result[j, i] = arr[i, j];

            }
        }
        return result;
    }

    private static void Main()
    {
        //Student Grading System Question
        Console.WriteLine("How many subjects are your students taking");
        int numOfSubjects = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of students: ");
        int studentsNum = Convert.ToInt32(Console.ReadLine());
        MyProgram.StudentsGrades(studentsNum + 1, numOfSubjects + 1);

        //Transpose array question
        int[,] arr = { { 5, 4, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
        int[,] result = MyProgram.transposeArray(arr);
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                if (j < result.GetLength(1) - 1)
                {
                    Console.Write(result[i, j] + "\t");
                }
                else
                {
                    Console.WriteLine(result[i, j]);
                }
            }
        }
    }

}