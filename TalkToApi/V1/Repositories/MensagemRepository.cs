﻿using System.Collections.Generic;
using System.Linq;
using TalkToApi.Database;
using TalkToApi.V1.Models;
using TalkToApi.V1.Repositories.Contracts;

namespace TalkToApi.V1.Repositories
{
    public class MensagemRepository : IMensagemRepository
    {
        private readonly TalkToContext _banco;
        public MensagemRepository(TalkToContext banco)
        {
            _banco = banco;
        }



        public Mensagem Obter(int id)
        {
            return _banco.Mensagem.Find(id);
        }
        public List<Mensagem> ObterMensagens(string usuarioUmId, string usuarioDoisId)
        {
            return _banco.Mensagem.Where(a => (a.DeId == usuarioUmId || a.DeId == usuarioDoisId) && (a.ParaId == usuarioUmId || a.ParaId == usuarioDoisId)).ToList();
        }

        public void Cadastrar(Mensagem mensagem)
        {
            _banco.Mensagem.Add(mensagem);
            _banco.SaveChanges();
        }

        public void Atualizar(Mensagem mensagem)
        {
            _banco.Mensagem.Update(mensagem);
            _banco.SaveChanges();
        }
    }
}
