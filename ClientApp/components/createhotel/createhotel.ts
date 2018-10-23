import Vue from 'vue';
import { Component } from 'vue-property-decorator';

declare var $: any;

@Component
export default class CreateHotelComponent extends Vue {
  data: Hotel;
  constructor() {
    super();
    this.data = new Hotel();
  }
  postNewReview() {
    //$.post("./api/Hotel/Review", { review: this.data.review });
    }
}

class Hotel {
  name: string;
  constructor() {
    this.name = "test hotel";
  }
}
