using Core.Models;
using Core.Service;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public class ServicoService : IServicoService
    {
        private readonly AjudakiContext context;

        public ServicoService(AjudakiContext context)
        {
            this.context = context;
        }

        public uint Create(Servico servico)
        {
            context.Add(servico);
            context.SaveChanges();
            return (uint)servico.Id;
        }

        public void Delete(uint id)
        {
            var servico = context.Servicos.Find(id);
            if (servico != null)
            {
                context.Remove(servico);
                context.SaveChanges();
            }
        }

        public void Edit(Servico servico)
        {
            context.Update(servico);
            context.SaveChanges();
        }

        public Servico? Get(uint id)
        {
            return context.Servicos
                .Include(s => s.IdTipoServicoNavigation)
                .Include(s => s.IdAreaAtuacaoNavigation)
                .Include(s => s.IdProfissionalNavigation)
                .AsNoTracking()
                .FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Servico> GetAll()
        {
            return context.Servicos
                .Include(s => s.IdTipoServicoNavigation)
                .Include(s => s.IdAreaAtuacaoNavigation)
                .Include(s => s.IdProfissionalNavigation)
                .AsNoTracking()
                .ToList();
        }

        public IEnumerable<Servico> GetByNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return Enumerable.Empty<Servico>();

            var termo = nome.Trim().ToLowerInvariant();

            return context.Servicos
                .Include(s => s.IdTipoServicoNavigation)
                .Include(s => s.IdAreaAtuacaoNavigation)
                .Include(s => s.IdProfissionalNavigation)
                .Where(s => !string.IsNullOrEmpty(s.Nome) &&
                            s.Nome.ToLower().StartsWith(termo))
                .AsNoTracking()
                .ToList();
        }

        public IEnumerable<Servico> GetAllInclude()
        {
            return context.Servicos
                .Include(s => s.IdProfissionalNavigation)
                .Include(s => s.IdAreaAtuacaoNavigation)
                .Include(s => s.IdTipoServicoNavigation)
                .AsNoTracking()
                .ToList();
        }
    }
}
