$(document).ready(function () {

    let state = {
        weapons: null,
        filteredWeapons: null
    }

    let dataService = {
        weaponDataToRender: (weapon) => {
            return {
                name: weapon.name,
                image: weapon.images.image,
                backgroundImg: weapon.images.background,
                rarity: weapon.rarity,
                ammocost: weapon.stats.ammocost,
                damageBody: weapon.stats.damage.body,
                damageHead: weapon.stats.damage.head,
                magazineReload: weapon.stats.magazine.reload,
                magazineSize: weapon.stats.magazine.size,
                dps: weapon.stats.dps,
                firerate: weapon.stats.firerate
            }
        }
    }

    let renderService = {
        renderQuickWeapons: (weapons) => {
            for (const weapon of weapons) {
                renderService.printQuickCard(dataService.weaponDataToRender(weapon))
            }
        },

        printQuickCard: (data) => {
            $("#theadRarity").hide();
            $("#stats").append(() => renderService.newQuickCard(data));
        },
        newQuickCard: (data) => {
            let epicBgImg = "https://images.fabric.com/images/200/200/DZ-506.jpg";
            let legendaryBgImg = "https://ncscolour.com/wp-content/uploads/2016/04/tempcolorimg-1935.jpg";
            let commonBgImg = "https://sherwin.scene7.com/is/image/sw/color-swatch?_tparam_size=250,250&layer=comp&_tparam_color=7D848B";
            let uncommonBgImg = "https://www.colorcombos.com/images/colors/3A5F0B.png";
            let rareBgImg = "https://www.colorcombos.com/images/colors/1FBED6.png"

            if (data.rarity == "epic") {
                data.backgroundImg = epicBgImg;
            } else if (data.rarity == "legendary") {
                data.backgroundImg = legendaryBgImg;
            } else if (data.rarity == "common") {
                data.backgroundImg = commonBgImg;
            } else if (data.rarity == "uncommon") {
                data.backgroundImg = uncommonBgImg;
            } else if (data.rarity == "rare") {
                data.backgroundImg = rareBgImg;
            }

            $("#quickSort").on("click", function () {
                $(".sortByTable").hide();
                $(".quickSort").show();
            })

            $(".quickSort").append($(`<div class="card" style="  display: inline-block; padding: 10px;border:3px solid black; margin: 10px; width: 300px; height: 800px;">
            <img class="card-img-top" id="quickImg" src="${data.image}" alt="" id="weaponimg">
            <img class="card-img-top" src="${data.backgroundImg}" alt="" id="bgimg">
            <div class="card-body">
                <h5 class="card-title" id="weaponName" style="text-align: center; font-size: 27px;  position: absolute; top: 700px;">${data.name}</h5>
            </div>
                <ul class="list-group list-group-flush" style="padding-top: 200px">
                <li class="list-group-item">Damage Body: ${data.damageBody}</li>
                <li class="list-group-item">Damage Head: ${data.damageHead}</li>
                <li class="list-group-item">Rarity: ${data.rarity}</li>
                <li class="list-group-item">Ammocost ${data.ammocost}</li>
                <li class="list-group-item">Weapon Reload: ${data.magazineReload}</li>
                <li class="list-group-item">Weapon Size: ${data.magazineSize}</li>
                <li class="list-group-item">Damage per second: ${data.dps}</li>
                <li class="list-group-item">Firerate: ${data.firerate}</li>
            </ul>
        </div>`))
        },

        renderTableWeapons: (weapons) => {

            $(".sortByTable").show();
            $(".quickSort").hide();
            $("#bodytable").html("")

            for (const weapon of weapons) {
                let weaponToRender = dataService.weaponDataToRender(weapon)
                renderService.renderTableCard(weaponToRender)
            }
        },

        renderTableCard: (weapon) => {
            $("#bodytable").append($(`
            <tr>
                <th style="width:50px height:50px" scope="row"><img src="${weapon.image}" ></th>
                <td>${weapon.name}</td>
                <td>${weapon.rarity}</td>
                <td>${weapon.dps}</td>
                <td>${weapon.damageBody}</td>
                <td>${weapon.damageHead}</td>
                <td>${weapon.firerate}</td>
                <td>${weapon.magazineSize}</td>
                <td>${weapon.magazineReload}</td>
            </tr>
            
        </table>`))
        },
        printByRarity: (rarity) => {
            state.filteredWeapons = state.weapons.filter(w => w.rarity === rarity)
            renderService.renderTableWeapons(state.filteredWeapons)
        }
    }
    $("#theadRarity").hide();
    function getDataFromFetch() {
        fetch("https://fortnite-public-api.theapinetwork.com/prod09/weapons/get")
            .then(res => res.json())
            .then(data => {
                state.weapons = data.weapons
                renderService.renderQuickWeapons(data.weapons)
            })
    }

    $("#weapons").on("click", function () {
        getDataFromFetch();
    })

    $("#btnSortByTable").on("click", function () {
        renderService.renderTableWeapons(state.weapons)
    })

    $("#commonFilter").on("click", function () {
        let common = weapons.rarity = "common"
        renderService.printByRarity(common);
    })
    $("#uncommonFilter").on("click", function () {
        let uncommon = weapons.rarity = "uncommon"
        renderService.printByRarity(uncommon);
    })
    $("#rareFilter").on("click", function () {
        let rare = weapons.rarity = "rare"
        renderService.printByRarity(rare);
    })
    $("#epicFilter").on("click", function () {
        let epic = weapons.rarity = "epic"
        renderService.printByRarity(epic);
    })
    $("#legendaryFilter").on("click", function () {
        let legendary = weapons.rarity = "legendary"
        renderService.printByRarity(legendary);
    })

})