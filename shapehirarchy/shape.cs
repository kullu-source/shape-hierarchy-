using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
public class Shape {

    public string Name { get; set; } = "Shape";
    public virtual double CalculateArea() {
        return 0.0;
    }
}

