<template>
    <div class="content">
        <div class="loginLeftSide">
            <img src="../assets/logohumano.svg" width="300px">
        </div>
        <div class="loginForm" v-if="!isLogged">
            <MtInput name='Usuario' type="text" icon="user" v-model="username"></MtInput>
            <MtInput name='Contraseña' type="password" icon="key" v-model="password"></MtInput>
            <br>
            <label id="RequestStatus">{{loginUserRequestStatus}}</label>
            <br>
            <button class="btnMain" @click="login">Iniciar Sesion</button>
            <br>
            <label class="signInMessage"> Aun no tienes una cuenta <nuxt-link to="register">Unete Aqui</nuxt-link> </label>
        </div>

        <div v-else id="UserLoggedInfo">
            <label>Ha iniciado sesion correctamente.</label>
        </div>
    </div>
</template>
<script>
export default {
    data() {
        return {
            username: "",
            password: "",
            loginUserRequestStatus: "",
            isLogged: false
        }
    },
    async mounted() {
    },
    methods: {
        async login() {
            if (this.username || this.password) {
                let requestUserLogin = await this.$axios.post(`${process.env.API_URL}/login`, {
                    Username: this.username,
                    Password: this.password
                });

                this.loginUserRequestStatus = requestUserLogin.data;
                if (this.loginUserRequestStatus == true) {
                    this.isLogged = true;
                    document.getElementsByClassName("content")[0].style.flexFlow = "column";
                }
            }
        }
    }
}
</script>

<style>
.content {
    display: flex;
    justify-content: center;
    align-items: center;
    flex-flow: row nowrap;
    width: 100%;
    height: 100%;
    background: #f2f5f8;
}

.loginLeftSide {
    margin-right: 100px;
}

.loginForm {
    display: flex;
    justify-content: center;
    align-items: center;
    flex-flow: column nowrap;
    width: 30%;
}

.signInMessage {
    font-family: 'inter';
    font-weight: 400;
    font-size: 14px;
}

.signInMessage a {
    color: #0fb8e2;
    font-weight: 900;
    text-decoration: none;
}

#UserLoggedInfo {
    color: #388E3C;
    font-weight: 400;
    font-size: 40px;
    margin-top: 30px;
    font-family: 'inter';
}
</style>