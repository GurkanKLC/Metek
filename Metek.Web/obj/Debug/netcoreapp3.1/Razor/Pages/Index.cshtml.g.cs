#pragma checksum "C:\Users\gurka\Documents\Metek\Metek\Metek.Web\Pages\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "844666a118e8d0fc7b3e7361fa3e376347748be24e7771942209fbe5e508f41d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Metek.Web.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Metek.Web.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\gurka\Documents\Metek\Metek\Metek.Web\Pages\_ViewImports.cshtml"
using Metek.Web

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"844666a118e8d0fc7b3e7361fa3e376347748be24e7771942209fbe5e508f41d", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"69a8ba831c3806b82e1f7819699ac6ac41b66cd379b44eaa8660be66d90b476f", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "false", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\gurka\Documents\Metek\Metek\Metek.Web\Pages\Index.cshtml"
  
    ViewData["Title"] = "Mesai Bilgileri";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "844666a118e8d0fc7b3e7361fa3e376347748be24e7771942209fbe5e508f41d4958", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"" />
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.bundle.min.js""></script>
    <title>");
                Write(
#nullable restore
#line 14 "C:\Users\gurka\Documents\Metek\Metek\Metek.Web\Pages\Index.cshtml"
            ViewData["Title"]

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""container mt-5"">
    <h2 class=""mb-4"">Mesai Bilgileri</h2>

    <table id=""mesaiTable"" class=""table table-striped table-bordered"">
        <thead class=""thead-dark"">
            <tr>
                <th>Personel</th>
                <th>Mesai Tarihi</th>
                <th>Giriş Zamanı</th>
                <th>Çıkış Zamanı</th>
                <th>Çalışma Süresi</th>
                <th>Fazla Mesai</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
</div>

<div class=""container mt-5"">
    <h2 class=""mb-4"">Mesai Listesi</h2>
    <button class=""btn btn-primary mb-3"" data-toggle=""modal"" data-target=""#addModal"">Yeni Mesai Ekle</button>

    <table id=""mesaiListTable"" class=""table table-striped table-bordered"">
        <thead class=""thead-dark"">
            <tr>
                <th>Personel</th>
                <th>İşlem Zamanı</th>
                <th>İşlem Durumu</th>
                <th>ID</th>
                <th>Oluşturulma Tari");
            WriteLiteral(@"hi</th>
                <th>Güncellenme Tarihi</th>
                <th>İşlemler</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
</div>

<div class=""modal fade"" id=""addModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""addModalLabel"">Yeni Mesai Ekle</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Kapat"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "844666a118e8d0fc7b3e7361fa3e376347748be24e7771942209fbe5e508f41d8521", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""addPersonel"">Personel</label>
                        <input type=""text"" class=""form-control"" id=""addPersonel"" required>
                    </div>
                    <div class=""form-group"">
                        <label for=""addProcessTime"">İşlem Zamanı</label>
                        <input type=""datetime-local"" class=""form-control"" id=""addProcessTime"" required>
                    </div>
                    <div class=""form-group"">
                        <label for=""addProcessStatus"">İşlem Durumu</label>
                        <select class=""form-control"" id=""addProcessStatus"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "844666a118e8d0fc7b3e7361fa3e376347748be24e7771942209fbe5e508f41d9543", async() => {
                    WriteLiteral("Aktif");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "844666a118e8d0fc7b3e7361fa3e376347748be24e7771942209fbe5e508f41d10817", async() => {
                    WriteLiteral("Pasif");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Kapat</button>
                        <button type=""submit"" class=""btn btn-primary"">Ekle</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""editModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""editModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""editModalLabel"">Düzenle</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "844666a118e8d0fc7b3e7361fa3e376347748be24e7771942209fbe5e508f41d14149", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""idInput"">ID</label>
                        <input type=""text"" class=""form-control"" id=""idInput"" readonly /> 
                    </div>
                    <div class=""form-group"">
                        <label for=""personelInput"">Personel</label>
                        <input type=""text"" class=""form-control"" id=""personelInput"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""processTimeInput"">İşlem Zamanı</label>
                        <input type=""datetime-local"" class=""form-control"" id=""processTimeInput"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""processStatusInput"">İşlem Durumu</label>
                        <input type=""checkbox"" id=""processStatusInput"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Kapat</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""updateMesai()"">Güncelle</button>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $.ajax({
                url: 'https://localhost:44309/Mesai/GetHakedis',
                method: 'GET',
                success: function (data) {
                    var tbody = $('#mesaiTable tbody');
                    tbody.empty(); 

                    $.each(data, function (index, item) {
                        tbody.append(
                            '<tr>' +
                            '<td>' + item.name + '</td>' +
                            '<td>' + item.mesaiDate + '</td>' +
                            '<td>' + item.entryDate + '</td>' +
                            '<td>' + item.exitDate + '</td>' +
                            '<td>' + item.workTime + '</td>' +
                            '<td>' + item.extraWorkTime + '</td>' +
                            '</tr>'
                        );
                    });
                },
                error: function () {
                    alert('Veriler a");
                WriteLiteral(@"lınırken bir hata oluştu.');
                }
            });

            $.ajax({
                url: 'https://localhost:44309/Mesai/GetList',
                method: 'GET',
                success: function (data) {
                    var tbody = $('#mesaiListTable tbody');
                    tbody.empty(); 

                    $.each(data, function (index, item) {
                        tbody.append(
                            '<tr>' +
                            '<td>' + item.personel + '</td>' +
                            '<td>' + new Date(item.processTime).toLocaleString() + '</td>' +
                            '<td>' + (item.processStatus ? 'Aktif' : 'Pasif') + '</td>' +
                            '<td>' + item.id + '</td>' +
                            '<td>' + new Date(item.createdDate).toLocaleString() + '</td>' +
                            '<td>' + new Date(item.updatedDate).toLocaleString() + '</td>' +
                            '<td>' +
                          ");
                WriteLiteral(@"  '<button class=""btn btn-warning btn-sm"" onclick=""openEditModal(' + item.id + ', \'' + item.personel + '\', \'' + item.processTime + '\', ' + item.processStatus + ')"">Düzenle</button>' +
                            '<button class=""btn btn-danger btn-sm"" onclick=""deleteMesai(' + item.id + ', \'' + item.personel + '\', \'' + item.processTime + '\', ' + item.processStatus + ')"">Sil</button>' +
                            '</td>' +
                            '</tr>'
                        );
                    });
                },
                error: function () {
                    alert('Veriler alınırken bir hata oluştu.');
                }
            });

            $('#addForm').on('submit', function (e) {
                e.preventDefault(); 

                var newData = {
                    mesaiAddRequest: {
                        personel: $('#addPersonel').val(),
                        processTime: $('#addProcessTime').val(),
                        processStatus: $('");
                WriteLiteral(@"#addProcessStatus').val() === 'true'
                    }
                };

                $.ajax({
                    url: 'https://localhost:44309/Mesai/Add',
                    method: 'POST',
                    data: JSON.stringify(newData),
                    contentType: 'application/json',
                    success: function () {
                        alert('Mesai başarıyla eklendi.');
                        $('#addModal').modal('hide');
                        $('#mesaiListTable').DataTable().ajax.reload(); 
                    },
                    error: function () {
                        alert('Ekleme işlemi sırasında bir hata oluştu.');
                    }
                });
            });

            $('#editForm').on('submit', function (e) {
                e.preventDefault(); 

                var updatedData = {
                    mesaiDeleteRequest: {
                        id: $('#editId').val(),
                        personel: $('#editPers");
                WriteLiteral(@"onel').val(),
                        processTime: $('#editProcessTime').val(),
                        processStatus: $('#editProcessStatus').val() === 'true'
                    }
                };
                console.log(updatedData);
                $.ajax({
                    url: 'https://localhost:44309/Mesai/Update',
                    method: 'PUT',
                    data: JSON.stringify(updatedData),
                    contentType: 'application/json',
                    success: function () {
                        alert('Mesai başarıyla güncellendi.');
                        $('#editModal').modal('hide');
                        $('#mesaiListTable').DataTable().ajax.reload(); 
                    },
                    error: function () {
                        alert('Güncelleme işlemi sırasında bir hata oluştu.');
                    }
                });
            });
        });
        function updateMesai() {
            var id = parseInt($('#editModal #");
                WriteLiteral(@"idInput').val(), 10);
            var personel = $('#editModal #personelInput').val(); 
            var processTime = $('#editModal #processTimeInput').val(); 
            var processStatus = $('#editModal #processStatusInput').is(':checked'); 

            var requestBody = {
                mesaiUpdateRequest: {
                    id: id,
                    personel: personel,
                    processTime: processTime,
                    processStatus: processStatus
                }
            };
            console.log(requestBody);
            $.ajax({
                url: 'https://localhost:44309/Mesai/Update', 
                method: 'PUT', 
                contentType: 'application/json', 
                data: JSON.stringify(requestBody), 
                success: function (response) {
                    alert('Güncelleme başarılı!');
                    $('#editModal').modal('hide'); 
                   
                    loadMesaiList(); 
                },
     ");
                WriteLiteral(@"           error: function (jqXHR, textStatus, errorThrown) {
                    console.log(jqXHR);
                    console.log(textStatus);
                    console.log(errorThrown);
                }
            });
        }
        function deleteMesai(id, personel, processTime, processStatus) {
            if (confirm('Bu kaydı silmek istediğinize emin misiniz?')) {
                var deleteData = {
                    mesaiDeleteRequest: {
                        id: id,
                        personel: personel, 
                        processTime: processTime, 
                        processStatus: processStatus 
                    }
                };

                $.ajax({
                    url: 'https://localhost:44309/Mesai/Delete',
                    method: 'DELETE',
                    data: JSON.stringify(deleteData),
                    contentType: 'application/json',
                    success: function () {
                        alert('Mesai b");
                WriteLiteral(@"aşarıyla silindi.');
                        $('#mesaiListTable').DataTable().ajax.reload(); 
                    },
                    error: function () {
                        alert('Silme işlemi sırasında bir hata oluştu.');
                    }
                });
            }
        }

        function openEditModal(id, personel, processTime, processStatus) {
            $('#editModal #idInput').val(id);
            $('#editModal #personelInput').val(personel);
            $('#editModal #processTimeInput').val(processTime);
            $('#editModal #processStatusInput').prop('checked', processStatus);

            $('#editModal').modal('show');
        }
        function setupDeleteButton(item) {
            $('#deleteButton').on('click', function () {
                deleteMesai(item.id, item.personel, item.processTime, item.processStatus);
            });
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
