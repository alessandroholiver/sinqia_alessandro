﻿using Projeto01_ConceitosWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto01_ConceitosWebAPI.Controllers
{
    public class ConceitosController : ApiController
    {
        [Route("nomes")]
        public List<string> GetNomes()
        {
            return Dados.ListarNomes();
        }

        public List<Produto> GetProdutos()
        {

            return Dados.ListarProdutos();
        }


        public Produto GetProduto(int id)
        {
            return Dados.ListarProdutos().Find(c => c.Id == id);
            
        }

        [Route("nome/{id}")]
        public string GetNome(string id)
        {
            return Dados.ListarNomes().Find(c => c.ToLower().Contains(id.ToLower()));

        }

        //Alterando o padrao de nomeclatura dos actions
        [Route("listaprodutos")]
        [HttpGet]
         public List<Produto> BuscarProdutos()
        {

            return Dados.ListarProdutos();
        }

        //Incluindo um novo produto
        public int PostProduto(Produto produto)
        {
            try
            {
                Dados.IncluirProduto(produto);
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }

        }


    }
}
