
using ReadCSV.Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;



// carregar arquivo CSV
var path = @"C:\dev\ReadCSV\itens.csv";

// ler todas as linhas do arquivo 
var lines = File.ReadAllLines(path);

// pular o header do arquivo 
var contentLines = lines.Skip(1).ToList();


//executar as linhas e verificar erros: lines.ToList().ForEach(line => Console.WriteLine(line));

foreach (var line in contentLines)
{
   var columns = line.Split(";");
   
    var item = new Item { 
        GroupId = int.Parse(columns[0]), 
        MaterialId = int.Parse(columns[1]),
        ItemQuantity = double.Parse(columns[2]),
        ItemDim1 = columns[3],
        ItemDim2 = columns[4],
        ItemDim3 = columns[5],
        ItemClass = columns[6]
    };

    Console.WriteLine(item.ToString());
   
}



