$(function () {
    var l = abp.localization.getResource('HayoonKorea');
    var createModal = new abp.ModalManager(abp.appPath + 'Phones/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Phones/EditModal');

    var phoneDtoProperties = [
        { title: l('Name'), data: 'name' },
        { title: l('Model'), data: 'model' },
        { title: l('Price'), data: 'price' },
        { title: l('Stock'), data: 'stock' },
        { title: l('Description'), data: 'description' },
        { title: l('BrandId'), data: 'brandId' },
        { title: l('ReleaseDate'), data: 'releaseDate', dataFormat: 'datetime' },
        { title: l('Width'), data: 'width' },
        { title: l('Height'), data: 'height' },
        { title: l('Depth'), data: 'depth' },
        { title: l('OS'), data: 'os' },
        { title: l('Processor'), data: 'processor' },
        { title: l('RAM'), data: 'ram' },
        { title: l('BatteryCapacity'), data: 'batteryCapacity' },
        { title: l('Size'), data: 'size' },
        { title: l('Resolution'), data: 'resolution' },
        { title: l('DisplayType'), data: 'displayType' },
        { title: l('RearCamera'), data: 'rear' },
        { title: l('FrontCamera'), data: 'front' },
        { title: l('Network'), data: 'network' },
        { title: l('Wifi'), data: 'wifi' },
        { title: l('Bluetooth'), data: 'bluetooth' },
        { title: l('Nfc'), data: 'nfc' },
        { title: l('Waterproof'), data: 'waterproof' },
        { title: l('WirelessCharging'), data: 'wirelessCharging' },
        { title: l('FaceUnlock'), data: 'faceUnlock' },
        { title: l('WarrantyPeriod'), data: 'warrantyPeriod' },
        { title: l('Tags'), data: 'tags' }
    ];

    var dataTable = $('#PhonesTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(hayoonKorea.phones.phone.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('HayoonKorea.Phones.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('HayoonKorea.Phones.Delete'),
                                    confirmMessage: function (data) {
                                        return l('PhoneDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        hayoonKorea.phones.phone
                                            .delete(data.record.id)
                                            .then(function() {
                                                abp.notify.info(l('SuccessfullyDeleted'));
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                }
            ]
                .concat(phoneDtoProperties.map(function (column) {
                    return {
                        title: column.title,
                        data: column.data,
                        render: function (data, type, row) {
                            // Special formatting for DateTime fields
                            if (column.dataFormat && column.dataFormat === "datetime") {
                                return new Date(data).toLocaleString();
                            }
                            // Special handling for Lists (e.g., Images, Tags)
                            if (Array.isArray(data)) {
                                return data.join(", ");
                            }
                            return data;
                        }
                    };
                }))
        })
    );

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewPhoneButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
