using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_agenda1._0.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipExcluir { get; }
        public abstract string ObterTipoCadastro();
        public abstract UserControl ObterListagem();

        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();
        public virtual void Filtrar()
        {
        }
        public virtual void OrdenarTarefas()
        {
        }
        public  virtual void AdicionarEtapasTarefa()
        {
        }
        public virtual void FinalizarEtapasTarefa()
        {
        }

        public virtual void VisualizarDespesasCategorias()
        {
        }

    }
}
