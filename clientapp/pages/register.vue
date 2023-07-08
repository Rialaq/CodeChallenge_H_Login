<template>
    <div class="contentRegister">
        <div class="RegisterHeader">
            <img src="../assets/logohumano.svg" width="300px">
        </div>
        <div id="RegisterForm">
            <div id="twoInputContainer" v-if="!complete">
                <MtInput name='Nombre' type="text" icon="user" v-model="name"></MtInput>
                <MtInput name='Apellido' type="text" icon="user" v-model="lastname"></MtInput>
            </div>
            <div id="inputContainers" v-if="!complete">
                <MtInput name='Correo' type="text" icon="mail" v-model="mail"></MtInput>
                <MtInput name='Usuario' type="text" icon="users" v-model="username"></MtInput>
                <MtInput name='Contraseña' type="password" icon="key" v-model="password"></MtInput>
            </div>
            <br>
            <div class="formFooter">
                <label id="RequestStatus">{{registerUserRequestStatus}}</label>
                <br>
                <button class="btnMain" v-if="!complete" @click="registerNewUser">Crear Cuenta</button>
                <button class="btnMain" v-else @click="$router.push('/')"><span class="i-arrow-left"></span> Volver a Iniciar Sesion</button>

            </div>
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
            password: "",
            registerUserRequestStatus: "",
            complete: false
        }
    },
    async mounted() {
    },
    methods: {
        async registerNewUser() {
            var answer = confirm("Seguro que desea crear el usuario ?");
            if (answer) {
                this.registerUserRequestStatus = "";
                this.complete = false;
                var registerUserRequest = await this.$axios.post(`${process.env.API_URL}/signin`, {
                    name: this.name,
                    lastname: this.lastname,
                    mail: this.mail,
                    username: this.username,
                    password: this.password,
                    IsVerifed: true
                });

                
                this.registerUserRequestStatus = registerUserRequest.data;
                let RequestStatus = document.querySelector("#RequestStatus");
                
                if(registerUserRequest.data == true)
                {
                    this.complete = true;
                    this.registerUserRequestStatus = "Se ha registrado correctamente, Favor iniciar sesion";
                    RequestStatus.style.color = '#1976D2';
                }
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

#twoInputContainer {
    display: flex;
    flex-flow: row nowrap;
}

#twoInputContainer :first-child {
    margin-right: 10px;
}

#RegisterForm {
    display: flex;
    justify-content: center;
    flex-flow: column nowrap;
}

#RequestStatus {
    display: flex;
    justify-content: center;
    align-items: center;
    font-family: 'inter';
    color: rgb(216, 48, 48);
}
</style>