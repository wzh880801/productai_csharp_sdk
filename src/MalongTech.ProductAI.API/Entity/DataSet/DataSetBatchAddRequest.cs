using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class DataSetBatchAddRequest : DataSetBatchModifyByFileBaseRequest<DataSetModifyResponse>
    {
        public DataSetBatchAddRequest(string imageSetId)
            : base(imageSetId, "urls_to_add")
        {

        }

        public DataSetBatchAddRequest(string imageSetId, System.IO.FileInfo csvFile)
            : this(imageSetId)
        {
            this.CsvFile = csvFile;
        }
    }
}