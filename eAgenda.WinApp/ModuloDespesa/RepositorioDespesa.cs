﻿using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.ModuloCategoria;

namespace eAgenda.WinApp.ModuloDespesa
{
    internal class RepositorioDespesa : RepositorioBase<Despesa>
    {
        internal List<Despesa> SelecionarPorCategoria(Categoria filtro)
        {
            return registros.FindAll(x => x.Categorias.Contains(filtro));
        }

        internal void VerificarCategoriaSemUso(RepositorioCategoria repositorioCategoria)
        {
            bool EmUso;
            foreach (Categoria c in repositorioCategoria.SelecionarTodos())
            {
                EmUso = false;
                foreach (Despesa d in registros)
                {
                    if (d.Categorias.Contains(c))
                        EmUso = true;
                }
                c.EmUso = EmUso;
            }

        }
    }
}
