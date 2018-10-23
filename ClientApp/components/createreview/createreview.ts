import Vue from 'vue';
import { Component } from 'vue-property-decorator';

declare var $: any;

@Component
export default class CreateReviewComponent extends Vue {
  currentcount: number = 0;
  data: Hotel;
  constructor() {
    super();
    this.data = new Hotel();
  }
  postNewReview() {
    $.post("./api/Hotel/Review", { review: this.data.review });
    }
}

class Hotel {
  review: string;
  constructor() {
    this.review = "test review";
  }
}
