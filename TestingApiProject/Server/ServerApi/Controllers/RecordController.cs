using Microsoft.AspNetCore.Mvc;
using ServerApi.Models;
using ServerApi.Services;

namespace ServerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        public IRecordService RecordService { get; set; }

        public RecordController(IRecordService service)
        {
            RecordService = service;
        }

        [HttpGet]
        public ActionResult<RecordsResponse> GetRecords(RecordsRequest request)
        {
            var records = RecordService.GetRecordsByUserId(request.UserId);
            return new RecordsResponse 
            {
                UserId = request.UserId,
                Details = records
            };
        }

        [HttpGet]
        public ActionResult<RecordsResponse> GetRecordsByTime(RecordsRequest request)
        {
            var records = RecordService.GetRecordsByTime(request.ByDate, request.UserId);
            return new RecordsResponse
            {
                UserId = request.UserId,
                Details = records
            };
        }

        [HttpPost]
        public ActionResult<RecordsResponse> InsertRecord(RecordsRequest request)
        {
            var insertedRecord = RecordService.InsertRecord(request.Record);
            return new RecordsResponse
            {
                UserId = insertedRecord.UserId,
                Details = insertedRecord.ToList()
            };
        }
    }
}