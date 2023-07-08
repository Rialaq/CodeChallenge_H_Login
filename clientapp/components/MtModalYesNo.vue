<template>
    <div :class="`modal modal${name}`">

        <div class="modalWindow">
            <!-- Modal Header -->
            <div class="modalHeader">
                <div class="modalTitle">
                    <span :class="`i-info`"></span>
                    <label>Advertencia</label>
                </div>
            </div>

            <!-- Modal Body -->
            <div class="modalBody">
                <label class="ModalYesNoLabel"> {{ message }} </label>
                <br>
                <div class="ModalYesNo">
                    <button class="btnMain" @click="$store.dispatch('ModalNoClose', 'YesNoCambiarImagen')">
                        No
                    </button>
                    <slot></slot>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    props: {
        name: String,
        message: String,
    },
    methods: {
        controlModal() {
            this.$store.dispatch('OpenModal', "");
        },
    }
}
</script>

<style>
.ModalYesNoLabel {
    color: #c3c4c5;
    font-family: 'inter';
    font-weight: 400;
}
</style>