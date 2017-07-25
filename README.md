# millionaireLINQs

### Project Description 

Used LINQ to build the requested collections from custom types, and then Console.WriteLine() each item in that resulting collection: 


### Specs
```
#### (1)
Given a collection of customers who are millionaires:
public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}

List<Customer> customers = new List<Customer>() {
   new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
   new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
   ...
};
```

Display how many millionaires per bank:
```
Example Output:
WF 2
BOA 1
FTB 1
CITI 1
```

#### (2)
Given:
```
List<Bank> banks = new List<Bank>() {
   new Bank(){ Name="First Tennessee", Symbol="FTB"},
   new Bank(){ Name="Wells Fargo", Symbol="WF"},
   new Bank(){ Name="Bank of America", Symbol="BOA"},
   new Bank(){ Name="Citibank", Symbol="CITI"},
};
```
- Output the millionaires, sorted ascending by their LAST name.
- Display the full name of the bank. 
```
Example output:
Tina Fey at Citibank
Joe Landy at Wells Fargo
...
```

