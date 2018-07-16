using System;
using System.Collections.Generic;
using System.Text;
using Shared.DTOs;
using DAL;
using DAL.Model;
using DAL.Repositories;
using AutoMapper;

namespace BLL.Services
{
    public class TicketService : IService<TicketDTO>
    {
        private IUnitOfWork _unitOfWork;
        private readonly IRepository<Ticket> _repository;
        private readonly IMapper _mapper;

        public TicketService(IMapper mapper, IUnitOfWork unitOfWork) {

            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.Tickets;
            _mapper = mapper;
        }

        public void Create(TicketDTO entity)
        {
            _repository.Create(_mapper.Map<TicketDTO, Ticket>(entity));
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public List<TicketDTO> FetchAll()
        {
            return _mapper.Map<List<Ticket>, List<TicketDTO>>(_repository.FetchAll());
        }

        public TicketDTO GetById(Guid id)
        {
            return  _mapper.Map<Ticket, TicketDTO>(_repository.GetById(id));
        }

        public void Update(TicketDTO newEntity)
        {
            _repository.Update(_mapper.Map<TicketDTO, Ticket>(newEntity));
        }
    }
}