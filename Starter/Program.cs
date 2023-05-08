using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

// int sophia1 = 90;
// int sophia2 = 86;
// int sophia3 = 87;
// int sophia4 = 98;
// int sophia5 = 100;

// int andrew1 = 92;
// int andrew2 = 89;
// int andrew3 = 81;
// int andrew4 = 96;
// int andrew5 = 90;

// int emma1 = 90;
// int emma2 = 85;
// int emma3 = 87;
// int emma4 = 98;
// int emma5 = 68;

// int logan1 = 90;
// int logan2 = 95;
// int logan3 = 87;
// int logan4 = 88;
// int logan5 = 96;

// int andrewSum = 0;
// int emmaSum = 0;
// int loganSum = 0;


// decimal andrewScore;
// decimal emmaScore;
// decimal loganScore;

// sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
// emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
// loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

// sophiaScore = (decimal)sophiaSum / currentAssignments;
// andrewScore = (decimal)andrewSum / currentAssignments;
// emmaScore = (decimal)emmaSum / currentAssignments;
// loganScore = (decimal)loganSum / currentAssignments;

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();


// Creo le matrici con i voti dei singoli studenti
int[] SophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] AndrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] EmmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] LoganScores = new int[] { 90, 95, 87, 88, 96 };

// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// int sophiaSum = 0;
// decimal sophiaScore;

// foreach (int item in SophiaScores)
// {
//     sophiaSum += item;
// }

// decimal media = (decimal)sophiaSum / currentAssignments;

// string vote = "";

// if (media > 90)
// {
//     vote = "A";
// }
// else if (media > 70 && media <= 90)
// {
//     vote = "B";
// }
// else if (media > 60 && media <= 70)
// {
//     vote = "C";
// }
// else
// {
//     vote = "D";
// }

// Console.WriteLine($"{sophiaSum}");
// Console.WriteLine($"{(decimal)sophiaSum / currentAssignments}");
// Console.WriteLine("name \t\tTotal \t\tScore \t\tVote\n");
// Console.WriteLine($"Sophia \t\t{sophiaSum} \t\t{(decimal)sophiaSum / currentAssignments} \t\t{vote}");
// Console.ReadLine();

// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// Creare una matrice di nomi degli studenti:
string[] studentsNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// Creo una nuova matrice che raccoglie i punteggi dello studente corrente del foreach
int[] studentScores = new int[10];

// Write the Report Header to the console
Console.WriteLine("name \t\tTotal \t\tScore \t\tVote\n");

foreach (string currentStudent in studentsNames)
{
    // string currentStudent = student;

    if (currentStudent == "Sophia")
        studentScores = SophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = AndrewScores;
    else if (currentStudent == "Emma")
        studentScores = EmmaScores;
    else if (currentStudent == "Logan")
        studentScores = LoganScores;

    // initialize/reset the sum of scored assignments
    int scoresSum = 0;

    // initialize the media student vote
    decimal mediaStudentScore = 0;


    foreach (int singleScore in studentScores)
    {
        scoresSum += singleScore;
    }

    mediaStudentScore = (decimal)scoresSum / currentAssignments;



    string studentVote = "";

    if (mediaStudentScore > 90)
    {
        studentVote = "A";
    }
    else if (mediaStudentScore > 70 && mediaStudentScore <= 90)
    {
        studentVote = "B";
    }
    else if (mediaStudentScore > 60 && mediaStudentScore <= 70)
    {
        studentVote = "C";
    }
    else
    {
        studentVote = "D";
    }
    // Console.WriteLine($"{mediaStudentScore}");
    Console.WriteLine($"{currentStudent} \t\t{scoresSum} \t\t{mediaStudentScore} \t\t{studentVote}");
}

