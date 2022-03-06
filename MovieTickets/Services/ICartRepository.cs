﻿using MovieTickets.Models;
using MovieTickets.ViewModels;
using System.Collections.Generic;

namespace MovieTickets.Services
{
    public interface ICartRepository
    {
        public List<Cart> GetAll(Cart cart);
  
        public void Insert(Cart mic);
        public void Delete(int id);
    }
}
