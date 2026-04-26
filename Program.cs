namespace ContractorProject;

class Program {
    static void Main(){
        List<Subcontractor> subcontractors = new List<Subcontractor>();

        Console.Writeline("Contractor / Subcontractor payment system");

        bool keepGoing = true;
        while (keepGoing) {
            Console.WriteLine("Enter subcontractor name (or 'exit' to quit):");
            string name = Console.ReadLine();
            if (name.ToLower() == "exit") {
                keepGoing = false;
                continue;
        
    }
}