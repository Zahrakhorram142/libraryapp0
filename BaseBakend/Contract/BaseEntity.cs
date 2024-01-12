using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.Contract;

public abstract class BaseEntity
{
    public BaseEntity()
    {
        IsActive = true;
        CreationDate = DateTime.Now;
        Random random = new Random();
        Id = random.Next(minValue: 1000, maxValue: 10000);
    }

    public BaseEntity(bool isActive)
    {
        IsActive = isActive;
        CreationDate = DateTime.Now;
        Random random = new Random();
        Id = random.Next(minValue: 1000, maxValue: 10000);
    }

    public BaseEntity(bool isActive, int minValue, int maxValue)
    {
        IsActive = isActive;
        CreationDate = DateTime.Now;
        Random random = new Random();
        Id = random.Next(minValue: minValue, maxValue: maxValue);
    }
    public int Id { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreationDate { get; set; }

    public abstract bool IsActivateItem();
}
