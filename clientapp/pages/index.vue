<template>
    <div class="content">
        <div class="loginLeftSide">
            <img src="../assets/logohumano.svg" width="300px">
        </div>
        <div class="loginForm">
            <MtInput name='Usuario' type="text" icon="user"></MtInput>
            <MtInput name='Contraseña' type="password" icon="key"></MtInput>
            <br>
            <button class="btnMain">Iniciar Sesion</button>
            <br>
            <label class="signInMessage"> Aun no tienes una cuenta <nuxt-link to="">Unete Aqui</nuxt-link> </label>
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
</style>