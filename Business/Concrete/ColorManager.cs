using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public Color Add(Color color)
        {
            throw new NotImplementedException();
        }

        public Color Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }
        public Color GetById(int colorId)
        {
            return _colorDal.Get(b => b.ColorId == colorId);
        }

        public Color Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
