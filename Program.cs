using System;
using System.IO;

var path = Path.Combine(Environment.CurrentDirectory, "globo");
var dirGlobo = Directory.CreateDirectory(path);

var dirAmNorte = dirGlobo.CreateSubdirectory("America do Norte");
var dirAmCentral = dirGlobo.CreateSubdirectory("America Central");
var dirAmSul = dirGlobo.CreateSubdirectory("America do Sul");

dirAmNorte.CreateSubdirectory("USA");
dirAmNorte.CreateSubdirectory("Mexico");
dirAmNorte.CreateSubdirectory("Canada");

dirAmCentral.CreateSubdirectory("Panama");

dirAmSul.CreateSubdirectory("Brasil");
dirAmSul.CreateSubdirectory("Paraguai");