using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
  public class SerieRepository : IRepository<Serie>
  {
    private List<Serie> listSeries = new List<Serie>();
    public void Delete(int id)
    {
      listSeries[id].setDelete();
    }

    public List<Serie> FindAll()
    {
      return listSeries;
    }

    public Serie FindById(int id)
    {
      throw new System.NotImplementedException();
    }

    public int NextId()
    {
      throw new System.NotImplementedException();
    }

    public void Save(Serie entity)
    {
      throw new System.NotImplementedException();
    }

    public void Update(int id, Serie entity)
    {
      throw new System.NotImplementedException();
    }
  }
}