window.ShowSwal = (type, message) => {
    if (type === "success") {
        Swal.fire(
            'Vellykket!',
            message,
            'success'
        )
    }
    if (type === "error") {
        Swal.fire(
            'Mislykket!',
            message,
            'error'
        )
    }
}

function ShowDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('show');
}

function HideDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('hide');
}

function ShowAddGroupModal() {
    $('#addGroupModal').modal('show');
}

function HideAddGroupModal() {
    $('#addGroupModal').modal('hide');
}

function ShowAddUserModal() {
    $('#addUserModal').modal('show');
}

function HideAddUserModal() {
    $('#addUserModal').modal('hide');
}

function ShowAddTenantModal() {
    $('#addTenantModal').modal('show');
}

function HideAddTenantModal() {
    $('#addTenantModal').modal('hide');
}

function DropdownToggle() {
    $('.dropdown-toggle').dropdown();
}
