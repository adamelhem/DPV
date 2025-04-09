namespace BusinessLogic
{
    public class Graph
    {

        private Dictionary<string,List<string>> _vertices;

        public void AddVertice(string v)
        {
            _vertices.Add(v, new List<string>());
        }

        public void AddEdge(string u, string v)
        {

        }

        public List<string> GetAdjacency(string vertice)
        {
            return this._vertices[vertice];
        }

    }
}