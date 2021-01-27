using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CSharpTest
{
	public partial class CMarket : Form
	{

		private const string apiURL = "http://127.0.0.1:5000/";
		private string token = "";

		public CMarket()
		{
			InitializeComponent();
		}

		private static HttpClient Client = new HttpClient();

		private async void listar(object sender, EventArgs e)
		{
			trocarPainel(1);
			using (var client = new HttpClient())
			{

				carregar(true);
				try
				{
					var response = await client.GetAsync(apiURL + "produtos");

					carregar(false);

					var resultadoStr = await response.Content.ReadAsStringAsync();
					var resultadoServico = JsonConvert.DeserializeObject<ResultadoServico>(resultadoStr);
					if (resultadoServico.erro)
					{
						MessageBox.Show(""+resultadoServico.conteudo, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						this.atualizaTabela(resultadoServico);							
					}
				}
				catch (Exception erro)
				{
					carregar(false);
					MessageBox.Show("Não foi possível obter os produtos : " + erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private async void buscarPorId(object sender, EventArgs e)
		{
			decimal id = numericPanelID.Value;

			if (id >= 0)
			{
				trocarPainel(1);
				using (var client = new HttpClient())
				{
					carregar(true);
					try
					{
						var response = await client.GetAsync(apiURL + "produto?id=" + id);
				
						carregar(false);

						var resultadoStr = await response.Content.ReadAsStringAsync();
						var resultadoServico = JsonConvert.DeserializeObject<ResultadoServico>(resultadoStr);
						if (resultadoServico.erro)
						{
							MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
						{
							numericPanelID.Value = 0;
							this.atualizaTabela(resultadoServico);
						}
					}
					catch (Exception erro)
					{
						carregar(false);
						MessageBox.Show("Não foi possível obter o produto : " + erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Preencha os campos corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void adicionar(object sender, EventArgs e)
		{
			string descricao = textPanelAdd.Text;
			decimal preco = numericPanelAdd.Value;

			if (preco >= 0 && descricao != "")
			{
				Produto produto = new Produto(0, descricao, preco);

				var content = JsonConvert.SerializeObject(produto);
				var byteContent = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
				byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

				carregar(true);
				try
				{
					var response = await Client.PostAsync(apiURL + "produto", byteContent);
				
					carregar(false);

					var resultadoStr = await response.Content.ReadAsStringAsync();
					var resultadoServico = JsonConvert.DeserializeObject<ResultadoServico>(resultadoStr);
					if (resultadoServico.erro)
					{
						MessageBox.Show(""+resultadoServico.conteudo, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						textPanelAdd.Text = "";
						numericPanelAdd.Value = 0;
						MessageBox.Show(""+resultadoServico.conteudo, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				catch (Exception erro)
				{
					carregar(false);
					MessageBox.Show("Não foi possível adicionar o produto : " + erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Preencha os campos corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void editar(object sender, EventArgs e)
		{
			decimal id = numericPanelEdit.Value;
			string descricao = textPanelEdit.Text;
			decimal preco = numeric2PanelEdit.Value;

			if (id > 0 && preco >= 0 && descricao != "")
			{
				Produto produto = new Produto(id, descricao, preco);

				var content = JsonConvert.SerializeObject(produto);
				var byteContent = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
				byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

				carregar(true);
				try
				{
					var response = await Client.PutAsync(apiURL + "produto", byteContent);

					carregar(false);

					var resultadoStr = await response.Content.ReadAsStringAsync();
					var resultadoServico = JsonConvert.DeserializeObject<ResultadoServico>(resultadoStr);
					if (resultadoServico.erro)
					{
						MessageBox.Show("" + resultadoServico.conteudo, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						numericPanelEdit.Value = 0;
						textPanelEdit.Text = "";
						numeric2PanelEdit.Value = 0;
						MessageBox.Show("" + resultadoServico.conteudo, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				catch (Exception erro)
				{
					carregar(false);
					MessageBox.Show("Não foi possível editar o produto : " + erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Preencha os campos corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void excluir(object sender, EventArgs e)
		{
			decimal id = numericPanelDelete.Value;

			if (id > 0)
			{

				carregar(true);
				try
				{
					var response = await Client.DeleteAsync(apiURL + "produto?id=" + id);
				
					carregar(false);

					var resultadoStr = await response.Content.ReadAsStringAsync();
					var resultadoServico = JsonConvert.DeserializeObject<ResultadoServico>(resultadoStr);
					if (resultadoServico.erro)
					{
						MessageBox.Show("" + resultadoServico.conteudo, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						numericPanelDelete.Value = 0;
						MessageBox.Show("" + resultadoServico.conteudo, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				catch (Exception erro)
				{
					carregar(false);
					MessageBox.Show("Não foi possível excluir o produto : " + erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Preencha os campos corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void logar(object sender, EventArgs e)
		{
			string login = textUsuarioPanelLogin.Text;
			string senha = textSenhaPanelLogin.Text;

			if (login != "" && senha != "")
			{
				var req = new
				{
					login,
					senha
				};

				var content = JsonConvert.SerializeObject(req);
				var byteContent = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
				byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

				carregar(true);
				try
				{
					var response = await Client.PostAsync(apiURL + "login", byteContent);

					carregar(false);

					var resultadoStr = await response.Content.ReadAsStringAsync();
					var resultadoServico = JsonConvert.DeserializeObject<ResultadoServico>(resultadoStr);
					if (resultadoServico.erro)
					{
						MessageBox.Show("" + resultadoServico.conteudo, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						token = resultadoServico.conteudo+"";
						labelAdm.Text = "Usuário ADMINISTRADOR!";
						labelAdm.ForeColor = Color.Green;
						Client.DefaultRequestHeaders.Clear();
						Client.DefaultRequestHeaders.Add("token", token);
						MessageBox.Show("Login realizado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

						bPanelLogin.Enabled = false;
						b2PanelLogin.Enabled = true;
						b3.Enabled = true;
						b4.Enabled = true;
						b5.Enabled = true;

						textUsuarioPanelLogin.Text = "";
						textSenhaPanelLogin.Text = "";
					}
				}
				catch (Exception erro)
				{
					carregar(false);
					MessageBox.Show("Não foi possível logar : " + erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Preencha os campos corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void atualizaTabela(ResultadoServico rs)
		{
			var produtos = JsonConvert.DeserializeObject<Produto[]>(rs.conteudo.ToString());
			var dataTable = JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(produtos));
			dataGridView.DataSource = dataTable;
		}

		private void carregar(bool ctx)
		{
			if (ctx)
			{
				carregando.Text = "CARREGANDO...";
				carregando.ForeColor = Color.DarkOrange;
			}
			//else
			{
				carregando.Text = "OK";
				carregando.ForeColor = Color.LimeGreen;
			}
		}

		private void trocarPainel(int num)
		{
			if (num == 1)
			{

				PanelID.Visible = false;
				PanelAdd.Visible = false;
				PanelEdit.Visible = false;
				PanelDelete.Visible = false;
				PanelLogin.Visible = false;
				dataGridView.Visible = true;

				PanelID.Location = new Point(1000, 1000);
				PanelAdd.Location = new Point(1000, 1000);
				PanelEdit.Location = new Point(1000, 1000);
				PanelDelete.Location = new Point(1000, 1000);
				PanelLogin.Location = new Point(1000, 1000);
				dataGridView.Location = new Point(15, 25);
			}
			if (num == 2)
			{
				dataGridView.Visible = false;
				PanelAdd.Visible = false;
				PanelEdit.Visible = false;
				PanelDelete.Visible = false;
				PanelLogin.Visible = false;
				PanelID.Visible = true;

				dataGridView.Location = new Point(1000, 1000);
				PanelAdd.Location = new Point(1000, 1000);
				PanelEdit.Location = new Point(1000, 1000);
				PanelDelete.Location = new Point(1000, 1000);
				PanelLogin.Location = new Point(1000, 1000);
				PanelID.Location = new Point(0, 0);
			}
			if (num == 3)
			{
				dataGridView.Visible = false;
				PanelID.Visible = false;
				PanelEdit.Visible = false;
				PanelDelete.Visible = false;
				PanelLogin.Visible = false;
				PanelAdd.Visible = true;

				dataGridView.Location = new Point(1000, 1000);
				PanelID.Location = new Point(1000, 1000);
				PanelEdit.Location = new Point(1000, 1000);
				PanelDelete.Location = new Point(1000, 1000);
				PanelLogin.Location = new Point(1000, 1000);
				PanelAdd.Location = new Point(0, 0);
			}
			if (num == 4)
			{
				dataGridView.Visible = false;
				PanelID.Visible = false;
				PanelAdd.Visible = false;
				PanelDelete.Visible = false;
				PanelLogin.Visible = false;
				PanelEdit.Visible = true;

				dataGridView.Location = new Point(1000, 1000);
				PanelID.Location = new Point(1000, 1000);
				PanelAdd.Location = new Point(1000, 1000);
				PanelDelete.Location = new Point(1000, 1000);
				PanelLogin.Location = new Point(1000, 1000);
				PanelEdit.Location = new Point(0, 0);
			}
			if (num == 5)
			{
				dataGridView.Visible = false;
				PanelID.Visible = false;
				PanelAdd.Visible = false;
				PanelEdit.Visible = false;
				PanelLogin.Visible = false;
				PanelDelete.Visible = true;

				dataGridView.Location = new Point(1000, 1000);
				PanelID.Location = new Point(1000, 1000);
				PanelAdd.Location = new Point(1000, 1000);
				PanelEdit.Location = new Point(1000, 1000);
				PanelLogin.Location = new Point(1000, 1000);
				PanelDelete.Location = new Point(0, 0);
			}
			if (num == 6)
			{
				dataGridView.Visible = false;
				PanelID.Visible = false;
				PanelAdd.Visible = false;
				PanelEdit.Visible = false;
				PanelDelete.Visible = false;
				PanelLogin.Visible = true;

				dataGridView.Location = new Point(1000, 1000);
				PanelID.Location = new Point(1000, 1000);
				PanelAdd.Location = new Point(1000, 1000);
				PanelEdit.Location = new Point(1000, 1000);
				PanelDelete.Location = new Point(1000, 1000);
				PanelLogin.Location = new Point(0, 0);
			}
		}

		private void bPanelID_Click(object sender, EventArgs e)
		{
			trocarPainel(2);
		}

		private void bPanelAdd_Click(object sender, EventArgs e)
		{
			trocarPainel(3);
		}

		private void bPanelEdit_Click(object sender, EventArgs e)
		{
			trocarPainel(4);
		}

		private void bPanelDelete_Click(object sender, EventArgs e)
		{
			trocarPainel(5);
		}

		private void bLogin_Click(object sender, EventArgs e)
		{
			trocarPainel(6);
		}

		private void bSair_Click(object sender, EventArgs e)
		{
			var res = MessageBox.Show("Deseja mesmo sair agora?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				Close();
			}
		}

		private void b2PanelLogin_Click(object sender, EventArgs e)
		{
			Client.DefaultRequestHeaders.Clear();
			token = "";
			labelAdm.Text = "Usuário NÃO ADMINISTRADOR!";
			labelAdm.ForeColor = Color.Firebrick;
			bPanelLogin.Enabled = true;
			b2PanelLogin.Enabled = false;

			b3.Enabled = false;
			b4.Enabled = false;
			b5.Enabled = false;
		}
	}
}
