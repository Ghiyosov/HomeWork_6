Doctor doctor_1 = new Doctor("Dr. Johns", "Cardiologist", 15);
System.Console.WriteLine(doctor_1.TreatPatient("Molly"));
System.Console.WriteLine(doctor_1.PerformMedicalExamination("Molly"));
System.Console.WriteLine(doctor_1.PrescribeMedication("Molly", "Antibiotics"));

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("****************************************************************");
Console.WriteLine();
Console.WriteLine();

Doctor doctor_2 = new Doctor("Dr. Manheton", "Pediator");
doctor_2.SetExperience(15);
System.Console.WriteLine(doctor_2.TreatPatient("Masha"));
System.Console.WriteLine(doctor_2.PerformMedicalExamination("Masha"));
System.Console.WriteLine(doctor_2.PrescribeMedication("Masha", "Vitamin"));

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("****************************************************************");
Console.WriteLine();
Console.WriteLine();






public class Doctor
{
    public string _fullName { get; set; }
    public string _specialty { get; set; }
    public int _exprience { get; set; }

    public Doctor(string fullname, string specialty, int exprience)
    {
        _fullName = fullname;
        _specialty = specialty;
        _exprience = exprience;
    }
    public Doctor(string fullname, string specialty)
    {
        _fullName = fullname;
        _specialty = specialty;
    }
    public Doctor()
    {

    }


    public string TreatPatient(string patientName)
    {
        return $"{_fullName}, {_specialty}, лечит пациента по имени {patientName}";
    }
    public string PerformMedicalExamination(string patientName)
    {
        return $"{_fullName} проводит медицинское обследование для пациента по имени {patientName}";
    }
    public string PrescribeMedication(string patientName, string medication)
    {
        return $"{_fullName} назначает {medication} пациенту по имени {patientName}";
    }
    public void SetExperience(int years)
    {
        _exprience = years;
    }
    public int GetExperience()
    {
        return _exprience;
    }

}