using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult // hangi tipi döndüreceğini çağıran söyleyecek - generic tip kullandık & ayrıca bu arkadaş bir IResult implementasyonu
    {
        T Data { get; }
    }
}
