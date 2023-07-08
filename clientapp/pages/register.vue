<template>
    <div class="contentRegister">
        <div class="RegisterHeader">
            <img src="../assets/logohumano.svg" width="300px">
        </div>
        <div class="RegisterForm">
            <div class="twoInputContainer">
                <MtInput name='Nombre' type="text" icon="user" v-model="name"></MtInput>
                <MtInput name='Apellido' type="text" icon="user" v-model="lastname"></MtInput>
            </div>
            <MtInput name='Correo' type="text" icon="mail" v-model="mail"></MtInput>
            <MtInput name='Usuario' type="text" icon="users" v-model="username"></MtInput>
            <MtInput name='Contraseña' type="password" icon="key" v-model="password"></MtInput>
            <br>
            <button class="btnMain" @click="registerUser">Crear Cuenta</button>
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
    methods: {
        async registerUser() {
            let reqData = await this.$axios.post(`${process.env.API_URL}/signin`, {
                Name: this.name,
                Lastname: this.lastname,
                Mail: this.mail,
                Username: this.username,
                Password: this.password,
                IsVerified: true
            });

            console.log(reqData.data);
        },
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