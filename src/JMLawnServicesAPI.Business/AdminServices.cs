using System.Collections.Generic;
using DTO = JMLawnServicesAPI.Business.Models;
using JMLawnServicesAPI.Data.Repositories;
using JMLawnServicesAPI.Data;

namespace JMLawnServicesAPI.Business
{
    public class AdminServices : IAdminServices{


        public DTO.Estimate CreateEstimate(DTO.Estimate newEstimate){
            var dao = DTO.Estimate.toDAO(newEstimate);
            var estimate = _repository.CreateEstimate(dao);
            var dao2 = _repository.GetEstimate(estimate.LocationID.value);
            var dto = DTO.Estimate.fromDAO(dao2);
            return dto;
        }

        public DTO.Estimate GetEstimate(int estimateID){
            var estimate = _repository.GetEstimate(estimateID);
            var dto = DTO.Estimate.fromDAO(estimate);
            return dto;
        }
    }
}