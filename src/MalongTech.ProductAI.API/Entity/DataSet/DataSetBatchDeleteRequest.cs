using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class DataSetBatchDeleteRequest : DataSetBatchModifyByFileBaseRequest<DataSetModifyResponse>
    {
        public DataSetBatchDeleteRequest(string imageSetId)
            : base(imageSetId, "urls_to_delete")
        {

        }

        public DataSetBatchDeleteRequest(string imageSetId, System.IO.FileInfo csvFile)
            : this(imageSetId)
        {
            this.CsvFile = csvFile;
        }
    }
}