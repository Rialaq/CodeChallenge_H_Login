<template>
    <div class="input" :style="`width: ${width};`">
        <!-- Header -->
        <span v-if="icon" :class="`i-${icon}`"></span>
        <label v-if="!label">{{ name }}</label>

        <input v-if="image" class="inputText" type="file" @change="cambiarImagen()" accept="image/*">

        <!-- Input [text, password, number, etc] -->
        <input v-else v-if="!options && !image" class="inputText" :type="type" @input="$emit('input', $event.target.value)"
            :placeholder="name">

        <!-- Select -->
        <div v-if="options" class="inputText">Escoja una opcion</div>
        <input type="text" class="inputSelectValue" hidden>
        <div class="inputSelect">
            <div v-for="option in options" :key="option" @click="setValue(option.value, option.text)"> {{ option.text }}
            </div>
        </div>
        <span style="cursor: pointer" v-if="options" @click="optionsControl" class="i-arrow-down"></span>
    </div>
</template>

<script>
export default {
    name: "MtInput",
    props: {
        icon: String,
        type: String,
        name: String,
        options: Array,
        image: String,
        width: "100%",
        optionsDiv: false,
        label: false,
        value: {
            type: String,
            default: ''
        }
    },
    methods: {
        cleanInput() {
            this.value = "";
        },

        setValue(value, text) {
            this.$el.children[2].innerHTML = text;
            this.$el.children[3].value = value;
            this.$emit('input', this.$el.children[3].value)
            this.$el.children[4].style.height = "0";
        },

        optionsControl() {
            let inputSelect = this.$el.children[4];
            if (!this.optionsDiv) {
                this.optionsDiv = true;
                inputSelect.style.height = "120px";
            }
            else {
                this.optionsDiv = false;
                inputSelect.style.height = "0";
            }
        },
    }
}
</script>

<style>
.input {
    background: white;
    border-radius: 10px;
    position: relative;
    display: flex;
    justify-content: flex-start;
    align-items: center;
    flex-flow: row nowrap;
    color: #51575c;
    margin-top: 50px;
    width: 100%;
    font-size: 14px;
    border: 1px solid #5e5e5e;
}

.input label {
    position: absolute;
    top: -30px;
    left: 0px;
    font-family: 'inter';
    font-weight: bold;
    border-radius: 5px;
}

.input span {
    font-size: 20px;
    margin: 15px;
    margin-right: 0px;
    padding: 5px;
    display: flex;
    justify-content: center;
    align-items: center;
}

.inputText {
    padding: 20px;
    background: transparent;
    border: none;
    outline: none;
    font-size: 18px;
    color: #212529;
    width: 100%;
    font-family: 'inter';
}

.inputSelect {
    display: flex;
    position: absolute;
    flex-flow: column nowrap;
    top: 50px;
    background: #2d3136;
    width: 100%;
    height: 0;
    max-height: 120px;
    overflow: hidden;
    overflow-y: scroll;
    border-bottom-left-radius: 15px;
    border-bottom-right-radius: 15px;
}

.inputSelect div {
    font-family: 'inter';
    font-size: 15px;
    padding: 13px;
    margin: 5px;
    border-radius: 20px;
}

.inputSelect div:hover {
    background: #212529;
    cursor: pointer;
}
</style>