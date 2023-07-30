using System.IO;
using MyDailyRoutineConsoleApp.Models;


//Creating my object tasks:
SetOfDailyTasks currentDailyTasks = new SetOfDailyTasks();
DateTime dateNow = DateTime.Now;
DateTime dia = DateTime.Now;
DateTime mes = DateTime.Now;


Console.WriteLine($"Welcome to your daily tasks!Today is {dateNow.ToString("dd/MM/yyyy")}");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Instructions: type it 'true' for each task done or 'false' for " +
"each task not done!");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("You have 2 chances to put the correct answer. If you type it a wrong value, " +
"you can type it more only 1 time!");




try{
    //Vars
    bool doneTaskMeditation; 
    bool doneTaskStretching;
    bool doneTaskCalisthenics;
    bool doneTaskFrench;
    bool doneTaskCsharpDotNet;
    bool doneTaskJava;
    bool doneTaskSqlDatabase;
    bool doneTaskExtremeProgramming;
    bool doneTaskSoftwareDesign;
    bool doneTaskElectronics;

    



    StreamWriter sw = new StreamWriter($"C:\\Rotinas2023/RotinaDia{dia.ToString("dd")}Mes{mes.ToString("MM")}.txt");
    sw.WriteLine($"Rotina da data = {dateNow.ToString("dd/MM/yyyy")}");

    try
    {
        
        Console.Write("Did you conclude the task 'Meditation'? >>> ");
        doneTaskMeditation = Convert.ToBoolean(Console.ReadLine());
        
            if (doneTaskMeditation == true) {
            Console.WriteLine($"Congratulations you done this task! You type it {doneTaskMeditation} ^_^ .");
            
        } 
        else if (doneTaskMeditation == false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskMeditation} (:/) .");
            
        } 
        
        
        
        
        
        currentDailyTasks.setMeditation(doneTaskMeditation);
        sw.WriteLine($"Meditation = {currentDailyTasks.getMeditation()}");
    } 
    
    catch (Exception e)
     {
         Console.WriteLine("Exception: " + e.Message);
          Console.WriteLine("YOU HAVE ONLY ONE MORE CHANCE");
          doneTaskMeditation = Convert.ToBoolean(Console.ReadLine());
          if (doneTaskMeditation == true) {
             Console.WriteLine($"Congratulations you done this task! You type it {doneTaskMeditation} ^_^ .");
            
             } else if (doneTaskMeditation == false){
                 Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskMeditation} (:/) .");
            
             }
         currentDailyTasks.setMeditation(doneTaskMeditation);
         sw.WriteLine($"Meditation = {currentDailyTasks.getMeditation()}");

     }

    try
    {
        Console.Write("Did you conclude the task 'Stretching'? >>> ");
        doneTaskStretching = Convert.ToBoolean(Console.ReadLine());
        
            if (doneTaskStretching == true) {
            Console.WriteLine($"Congratulations you done this task! You type it {doneTaskStretching} ^_^ .");
           
        } else if (doneTaskStretching == false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskStretching} (:/) .");
            
        } 
        
        currentDailyTasks.setStretching(doneTaskStretching);
        sw.WriteLine($"Stretching = {currentDailyTasks.getStretching()}");
    } 
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
        Console.WriteLine("YOU HAVE ONLY ONE MORE CHANCE");
        doneTaskStretching = Convert.ToBoolean(Console.ReadLine());
        if (doneTaskStretching == true) {
        Console.WriteLine($"Congratulations you done this task! You type it {doneTaskStretching} ^_^ .");
            
        } else if (doneTaskStretching == false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskStretching} (:/) .");
            
            }
        currentDailyTasks.setStretching(doneTaskStretching);
        sw.WriteLine($"Stretching = {currentDailyTasks.getStretching()}");
    }

    try
    {
        Console.Write("Did you conclude the task 'Calisthenics'? >>> ");
        doneTaskCalisthenics = Convert.ToBoolean(Console.ReadLine());

            if(doneTaskCalisthenics == true) {
            Console.WriteLine($"Congratulations you done this task! You type it {doneTaskCalisthenics} ^_^ .");
            
        } else if (doneTaskCalisthenics == true) {
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskCalisthenics} (:/) .");
            
        } 
        
        currentDailyTasks.setCalisthenics(doneTaskCalisthenics);
        sw.WriteLine($"Calisthenics = {currentDailyTasks.getCalisthenics()}");
    } 
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
        Console.WriteLine("YOU HAVE ONLY ONE MORE CHANCE");
        doneTaskCalisthenics = Convert.ToBoolean(Console.ReadLine());
        if (doneTaskCalisthenics == true) {
        Console.WriteLine($"Congratulations you done this task! You type it {doneTaskCalisthenics} ^_^ .");
            
        } else if (doneTaskCalisthenics == false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskCalisthenics} (:/) .");
            
            }
        currentDailyTasks.setStretching(doneTaskCalisthenics);
        sw.WriteLine($"Calisthenics = {currentDailyTasks.getCalisthenics()}");
    }

    try
    {
        Console.Write("Did you conclude the task 'French'? >>> ");
        doneTaskFrench = Convert.ToBoolean(Console.ReadLine());
        
            if(doneTaskFrench == true) {
            Console.WriteLine($"Congratulations you done this task! You type it {doneTaskFrench} ^_^ .");
            
        } else if (doneTaskFrench == false)
        {
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskFrench} (:/)");
            
        } 
        currentDailyTasks.setFrench(doneTaskFrench);
        sw.WriteLine($"French = {currentDailyTasks.getFrench()}");
    } 
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
        Console.WriteLine("YOU HAVE ONLY ONE MORE CHANCE");
        doneTaskFrench = Convert.ToBoolean(Console.ReadLine());
        if (doneTaskFrench == true) {
        Console.WriteLine($"Congratulations you done this task! You type it {doneTaskFrench} ^_^ .");
            
        } else if (doneTaskFrench == false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskFrench} (:/) .");
            
            }
        currentDailyTasks.setFrench(doneTaskFrench);
        sw.WriteLine($"French = {currentDailyTasks.getFrench()}");
    }

    try
    {
        Console.Write("Did you conclude the task 'C#/.Net'? >>> ");
        doneTaskCsharpDotNet = Convert.ToBoolean(Console.ReadLine());
        
            if (doneTaskCsharpDotNet == true) {
            Console.WriteLine($"Congratulations you done this task! You type it {doneTaskCsharpDotNet} ^_^");
            
        } else if (doneTaskCsharpDotNet == false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskCsharpDotNet} (:/)");
            
        } 

        currentDailyTasks.setCsharpDotNet(doneTaskCsharpDotNet);
        sw.WriteLine($"C#/.Net = {currentDailyTasks.getCsharpDotNet()}");
    } 
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
        Console.WriteLine("YOU HAVE ONLY ONE MORE CHANCE");
        doneTaskCsharpDotNet = Convert.ToBoolean(Console.ReadLine());
        if (doneTaskCsharpDotNet == true) {
        Console.WriteLine($"Congratulations you done this task! You type it {doneTaskCsharpDotNet} ^_^ .");
            
        } else if (doneTaskCsharpDotNet == false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskCsharpDotNet} (:/) .");
            
            }
        currentDailyTasks.setFrench(doneTaskCsharpDotNet);
        sw.WriteLine($"C#/.NET = {currentDailyTasks.getCsharpDotNet()}");
    }

    try
    {
        Console.Write("Did you conclude the task 'Java'? >>> ");
        doneTaskJava = Convert.ToBoolean(Console.ReadLine());
        
            if(doneTaskJava == true) {
            Console.WriteLine($"Congratulations you done this task! You type it {doneTaskJava} ^_^");
            
        } else if (doneTaskJava == false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskJava} (:/)");
            
        } 
        
        currentDailyTasks.setJava(doneTaskJava);
        sw.WriteLine($"Java = {currentDailyTasks.getJava()}");
    } 
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
        Console.WriteLine("YOU HAVE ONLY ONE MORE CHANCE");
        doneTaskJava = Convert.ToBoolean(Console.ReadLine());
        if (doneTaskJava == true) {
        Console.WriteLine($"Congratulations you done this task! You type it {doneTaskJava} ^_^ .");
            
        } else if (doneTaskJava == false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskJava} (:/) .");
            
            }
        currentDailyTasks.setJava(doneTaskJava);
        sw.WriteLine($"Java = {currentDailyTasks.getJava()}");
    }

    try
    {
        Console.Write("Did you conclude the task 'SQL Database'? >>> ");
        doneTaskSqlDatabase = Convert.ToBoolean(Console.ReadLine());
        
            if(doneTaskSqlDatabase == true) {
            Console.WriteLine($"Congratulations you done this task! You type it {doneTaskSqlDatabase} ^_^");
            
        } else if (doneTaskSqlDatabase == false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskSqlDatabase} (:/)");
            
        } 
        
        currentDailyTasks.setSqlDatabase(doneTaskSqlDatabase);
        sw.WriteLine($"SQL Database = {currentDailyTasks.getSqlDatabase()};");
    } 
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
        Console.WriteLine("YOU HAVE ONLY ONE MORE CHANCE");
        doneTaskSqlDatabase = Convert.ToBoolean(Console.ReadLine());
        if (doneTaskSqlDatabase == true) {
        Console.WriteLine($"Congratulations you done this task! You type it {doneTaskSqlDatabase} ^_^ .");
            
        } else if (doneTaskSqlDatabase== false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskSqlDatabase} (:/) .");
            
            }
        currentDailyTasks.setSqlDatabase(doneTaskSqlDatabase);
        sw.WriteLine($"SQL Database = {currentDailyTasks.getSqlDatabase()}");
    }

    try
    {
        Console.Write("Did you conclude the task 'ExtremeProgramming'? >>> ");
        doneTaskExtremeProgramming = Convert.ToBoolean(Console.ReadLine());
        
            if(doneTaskExtremeProgramming == true) {
            Console.WriteLine($"Congratulations you done this task! You type it {doneTaskExtremeProgramming} ^_^");
            
        } else if (doneTaskExtremeProgramming == false) {
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskExtremeProgramming} (:/)");
            
        } 

        currentDailyTasks.setExtremeProgramming(doneTaskExtremeProgramming);
        sw.WriteLine($"Extreme Programming = {currentDailyTasks.getExtremeProgramming()};");
    } 
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
        Console.WriteLine("YOU HAVE ONLY ONE MORE CHANCE");
        doneTaskExtremeProgramming = Convert.ToBoolean(Console.ReadLine());
        if (doneTaskExtremeProgramming == true) {
        Console.WriteLine($"Congratulations you done this task! You type it {doneTaskExtremeProgramming} ^_^ .");
            
        } else if (doneTaskExtremeProgramming== false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskExtremeProgramming} (:/) .");
            
            }
        currentDailyTasks.setExtremeProgramming(doneTaskExtremeProgramming);
        sw.WriteLine($"Extreme Programming = {currentDailyTasks.getExtremeProgramming()}");
    }

    try
    {
        Console.Write("Did you conclude the task 'SoftwareDesign'? >>> ");
        doneTaskSoftwareDesign = Convert.ToBoolean(Console.ReadLine());
       
            if(doneTaskSoftwareDesign == true) {
            Console.WriteLine($"Congratulations you done this task! You type it {doneTaskSoftwareDesign} ^_^.");
            
        } else if (doneTaskSoftwareDesign == false) {
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type ir {doneTaskSoftwareDesign} (:/).");
            
        } 
        
        currentDailyTasks.setSoftwareDesign(doneTaskSoftwareDesign);
        sw.WriteLine($"Software Design = {currentDailyTasks.getSoftwareDesign()};");
    } 
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
        Console.WriteLine("YOU HAVE ONLY ONE MORE CHANCE");
        doneTaskSoftwareDesign = Convert.ToBoolean(Console.ReadLine());
        if (doneTaskSoftwareDesign == true) {
        Console.WriteLine($"Congratulations you done this task! You type it {doneTaskSoftwareDesign} ^_^ .");
            
        } else if (doneTaskSoftwareDesign == false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskSoftwareDesign} (:/) .");
            
            }
        currentDailyTasks.setSoftwareDesign(doneTaskSoftwareDesign);
        sw.WriteLine($"Software Design = {currentDailyTasks.getSoftwareDesign()}");
    }

    try
    {
        Console.Write("Did you conclude the task 'Electronics'? >>> ");
            doneTaskElectronics = Convert.ToBoolean(Console.ReadLine());
            if(doneTaskElectronics == true) {
            Console.WriteLine($"Congratulations you done this task! You type it {doneTaskElectronics} ^_^.");
            
        } else if (doneTaskElectronics == false) {
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type ir {doneTaskElectronics} (:/).");
            
        } 
        
        currentDailyTasks.setElectronics(doneTaskElectronics);
        sw.WriteLine($"Electronics = {currentDailyTasks.getElectronics()};");
    } 
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
        Console.WriteLine("YOU HAVE ONLY ONE MORE CHANCE");
        doneTaskElectronics = Convert.ToBoolean(Console.ReadLine());
        if (doneTaskElectronics == true) {
        Console.WriteLine($"Congratulations you done this task! You type it {doneTaskElectronics} ^_^ .");
            
        } else if (doneTaskElectronics == false){
            Console.WriteLine($"Sorry you didn't. But tomorrow you will can! You type it {doneTaskElectronics} (:/) .");
            
            }
        currentDailyTasks.setElectronics(doneTaskElectronics);
        sw.WriteLine($"Electronics = {currentDailyTasks.getElectronics()}");
    }
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("You filled out your Daily Routine");
    sw.Close();
}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
