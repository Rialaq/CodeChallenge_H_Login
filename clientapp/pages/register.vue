<template>
    <div class="contentRegister">
        <div class="RegisterHeader">
            <img src="../assets/logohumano.svg" width="300px">
        </div>
        <div class="RegisterForm">
            <div class="twoInputContainer">
                <MtInput name='Nombre' type="text" icon="user"></MtInput>
                <MtInput name='Apellido' type="text" icon="user"></MtInput>
            </div>
            <MtInput name='Correo' type="text" icon="mail"></MtInput>
            <MtInput name='Usuario' type="text" icon="users"></MtInput>
            <MtInput name='Contraseña' type="password" icon="key"></MtInput>
            <br>
            <button class="btnMain">Crear Cuenta</button>
        </div>
    </div>
</template>
<script>
export default {
    data() {
        return {
            feeds: []
        }
    },
    async mounted() {
    },
    methods: {}
}
</script>

<style>
.contentRegister {
    display: flex;
    justify-content: center;
    align-items: center;
    flex-flow: column nowrap;
    width: 100%;
    height: 100%;
    background: #f2f5f8;
}

.twoInputContainer {
    display: flex;
    flex-flow: row nowrap;
}

.twoInputContainer :first-child {
    margin-right: 10px;
}
</style>