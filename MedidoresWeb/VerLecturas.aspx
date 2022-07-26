﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="MedidoresWeb.VerLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Lecturas</h3>
                </div>
                <div class="card-body">
                    
  
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        
                        EmptyDataText="No hay Lecturas" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grillaLecturas">
                       <Columns>
                           <asp:BoundField DataField="Medidor.Nombre" HeaderText="Medidor" />
                           <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                           <asp:BoundField DataField="Hora" HeaderText="Hora" />
                           <asp:BoundField DataField="Minuto" HeaderText="Minuto" />
                           <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                          
                       </Columns>
                    </asp:GridView>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
