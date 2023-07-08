// State.
export const state = () => ({
    _status: false,
    _statusYesNoModal: false,
});

// Getters.
export const getters = {}

// Acciones
export const actions = {
    ModalYesNo({ state, commit }, modal) {
        var actualModal = document.querySelector(`.modal${modal}`);
        var actualWindow = actualModal.children[0];
        if (!state._statusYesNoModal) {
            commit('changeStatusModalYesNo');
            actualModal.style.display = "flex";
            setTimeout(() => { actualModal.style.opacity = "100"; }, 100);
            setTimeout(() => {
                actualWindow.style.opacity = "100";
                actualWindow.style.transform = "scale(1.0)";
            }, 300);
        }
    },

    ModalNoClose({ state, commit }, modal) {
        var actualModal = document.querySelector(`.modal${modal}`);
        if (state._statusYesNoModal) {
            commit('changeStatusModalYesNo');
            setTimeout(() => {
                actualModal.style.opacity = "0";
                actualModal.children[0].style.transform = "scale(0.9)";
                actualModal.children[0].style.opacity = "0";
            }, 100);
            setTimeout(() => { actualModal.style.display = "none"; }, 300);
        }
    },
}

// Mutaciones.
export const mutations = {
    changeStatusModalYesNo(state) {
        state._statusYesNoModal == false ? state._statusYesNoModal = true : state._statusYesNoModal = false;
    },
}