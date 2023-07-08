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
            <button class="btnMain" @click="registerNewUser">Crear Cuenta</button>
        </div>
    </div>
</template>
<script>
export default {
    data() {
        return {
            name: "",
            lastname: "",
            mail: "",
            username: "",
            password: ""
        }
    },
    async mounted() {
    },
    methods: {
        async registerNewUser() {
            var answer = confirm("Seguro que desea crear el usuario ?");
            if (answer) {
                var registerUserRequest = await this.$axios.post(`${process.env.API_URL}/signin`, {
                    name: this.name,
                    lastname: this.lastname,
                    mail: this.mail,
                    username: this.username,
                    password: this.password,
                    IsVerifed: true
                });

                console.log(registerUserRequest);
                alert("Usuario creado correctamente");
            }
        }
    }
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