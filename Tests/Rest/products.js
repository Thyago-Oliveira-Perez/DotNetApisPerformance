import http from "k6/http";
import { check, sleep } from "k6";

export let options = {
  stages: [
    { duration: "1m", target: 30 }, // Ramp up to 30 users over 1 minute.
    { duration: "2m", target: 30 }, // Stay at 30 users for 2 minutes.
    { duration: "1m", target: 0 }, // Ramp down to 0 users over 1 minute.
  ],
};

export default function () {
  let response = http.get("http://localhost:5000/Product/First1000Products");

  check(response, {
    "is status 200": (r) => r.status === 200,
    "is data returned": (r) => r.body.length > 0,
  });

  sleep(1);
}
