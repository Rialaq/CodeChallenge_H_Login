<template>
    <div :class="`modal modal${name}`">
        <div class="modalWindow">
            <!-- Modal Header -->
            <div class="modalHeader">
                <div class="modalTitle">
                    <span :class="`i-${icon}`"></span>
                    <label>{{ label }}</label>
                </div>

                <button class="modalClose i-x" v-if="!notClose" @click="controlModal"></button>
            </div>
            
            <!-- Modal Body -->
            <div class="modalBody">
                <slot></slot>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    props: {
        icon: String,
        name: String,
        label: String,
        notClose: Boolean,
    },
    methods: {
        controlModal() {
            this.$store.dispatch('OpenModal', "");
        },
    }
}
</script>

<style>
.modal {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.30);
    display: none;
    opacity: 0;
    justify-content: center;
    align-items: center;
    flex-flow: column nowrap;
    z-index: 300;
}

.modalWindow {
    background: #212529;
    border-radius: 10px;
    min-width: 400px;
    max-height: 800px;
    overflow: hidden;
    opacity: 0;
    transform: scale(0.9);
    display: flex;
    justify-content: flex-start;
    flex-flow: column nowrap;
}

.modalHeader {
    display: flex;
    justify-content: space-between;
    flex-flow: row nowrap;
    align-items: center;
    font-family: 'inter';
    color: #c3c4c5;
    font-weight: bold;
    font-size: 20px;
    padding: 30px;
    background: #2d3137;
}

.modalHeader span {
    margin-right: 10px;
}

.modalClose {
    color: #c3c4c5;
    font-size: 20px;
    background: none;
    border: none;
    cursor: pointer;
}

.modalBody {
    padding: 25px;
    display: flex;
    height: 100%;
    display: flex;
    justify-content: flex-start;
    align-items: center;
    flex-flow: column nowrap;
    overflow: hidden;
    overflow-y: scroll;
}

@media only screen and (max-width: 600px) {
    .modalWindow {
        min-width: 98%;
    }
}
</style>