// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
Dictionary<string, int> polyhedronFaces = new Dictionary<string, int>()
            {
                { "Tetrahedron", 4 },
                { "Cube", 6 },
                { "Octahedron", 8 },
                { "Dodecahedron", 12 },
                { "Icosahedron", 20 }
            };

int totalFaces = 0;
for (int i = 0; i < n; i++)
{
    string polyhedron = Console.ReadLine();
    totalFaces += polyhedronFaces[polyhedron];
}

Console.WriteLine(totalFaces);