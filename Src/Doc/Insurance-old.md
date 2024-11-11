# Business

| Id                                   | Name              | Name                            |
|--------------------------------------|-------------------|---------------------------------|
| 98e526b3-669b-4045-bc6a-4f78f065f842 | شرکت بیمه دیجی پی | Electronic Equipments Insurance |
|                                      |                   |                                 |

# Service

| Id                                   | Title                  | Name                            |
|--------------------------------------|------------------------|---------------------------------|
| a968920c-c420-4edf-98bc-72bf4a213dc5 | بیمه تجهیزات الکترونیک | Electronic Equipments Insurance |
|                                      |                        |                                 |

# SaleChannel

| Id                                   | Keyword     | Title    |
|--------------------------------------|-------------|----------|
| 2430b92b-1f77-4e89-a0a3-ad20024c5e50 | USED_DEVICE | کار کرده |
|                                      |             |          |

# Template

| Id                                   | Template-Name | Wage-Percent | Max-Compensation-Amount | Include-Tax | Duration-Unit | Service-Id                           | Service-Title          |
|--------------------------------------|---------------|--------------|-------------------------|-------------|---------------|--------------------------------------|------------------------|
| dbe3ef58-7240-11ee-a9e4-39301accecaf | premium_saman | 0.02         |                         | true        | 60            | a968920c-c420-4edf-98bc-72bf4a213dc5 | بیمه تجهیزات الکترونیک |
|                                      |               |              |                         |             |               |                                      |                        |

# Coverage

| Id | Template-Id                          | Title            | Rules-Html | Cover-Taxonomy-key | Cover-Taxonomy-Title | Is-Total-Lost |
|----|--------------------------------------|------------------|------------|--------------------|----------------------|---------------|
| ?  | dbe3ef58-7240-11ee-a9e4-39301accecaf | بیمه ضربه و آسیب |            | Damage             | ضربه و آسیب          | false         |
| ?  | dbe3ef58-7240-11ee-a9e4-39301accecaf | بیمه آتش سوزی    |            | Fire               | آتش سوزی             | false         |
| ?  | dbe3ef58-7240-11ee-a9e4-39301accecaf | بیمه سرقت        |            | Stealing           | سرقت                 | false         |
| ?  | dbe3ef58-7240-11ee-a9e4-39301accecaf | بیمه نفوذ مایعات |            | Water              | نفوذ مایعات          | false         |
|    |                                      |                  |            |                    |                      |               |

# TemplateDetail

| Id | Template-Id | Private-Terms_Html |
|----|-------------|--------------------|
| ?  | ?           | کار کرده           |
|    |             |                    |

# SaleChannel-Template

| Id                                   | Sale-Channel-Id                      | Template-Id                          | Business-Id                          | Is-Default |
|--------------------------------------|--------------------------------------|--------------------------------------|--------------------------------------|------------|
| 7aaf9efb-7243-11ee-a9e4-39301accecaf | 2430b92b-1f77-4e89-a0a3-ad20024c5e50 | dbe3ef58-7240-11ee-a9e4-39301accecaf | dbe3ef58-7240-11ee-a9e4-39301accecaf | true       |
|                                      |                                      |                                      |                                      |            |

# Pricing

| Id                                   | Title          | Max-Value | Min-Value | Wage-Percent | Fixed-Wage-Amount | Sale-Channel | Category | Brand | Model |
|--------------------------------------|----------------|-----------|-----------|--------------|-------------------|--------------|----------|-------|-------|
| 98e526b3-669b-4045-bc6a-4f78f065f842 | کمپین آبان 403 |           |           | 0.01         |                   | USED_DEVICE  | MOBILE   |       |       |
|                                      |                |           |           |              |                   |              |          |       |       |
| 98e526b3-669b-4045-bc6a-4f78f065f832 | کمپین آبان 403 |           |           | 0.02         |                   | BUNDLE       | MOBILE   |       |       |
| 98e526b3-669b-4045-bc6a-4f78f065f832 | کمپین آبان 403 |           |           | 0.02         |                   | BUNDLE       | LAPTOP   |       |       |
|                                      |                |           |           |              |                   |              |          |       |       |

## What we sell in USED journey?

```json
{
  "Service": "Electronic Equipments Insurance",
  "SaleChannel": "USED_DEVICE",
  "Template": {
    "Template_name": "premium_saman",
    "Duration": 60,
    "Wage_percent": 0.02,
    "Max_compensation_amount": null,
    "Include_tax": true,
    "Active_to": null,
    "Active_from": null,
    "Coverages": [
      {
        "Title": "بیمه سرقت",
        "Cover_taxonomy_key": "Stealing",
        "Cover_taxonomy_title": "سرقت",
        "Is_total_lost": false
      },
      {
        "Title": "بیمه ضربه و آسیب",
        "Cover_taxonomy_key": "Damage",
        "Cover_taxonomy_title": "ضربه و آسیب",
        "Is_total_lost": false
      },
      {
        "Title": "بیمه نفوذ مایعات",
        "Cover_taxonomy_key": "Water",
        "Cover_taxonomy_title": "نفوذ مایعات",
        "Is_total_lost": false
      },
      {
        "Title": "بیمه آتش سوزی",
        "Cover_taxonomy_key": "Fire",
        "Cover_taxonomy_title": "آتش سوزی",
        "Is_total_lost": false
      }
    ],
    "Pricing": [
      {
        "Max_value": null,
        "Min_value": null,
        "Wage_percent": 0.01,
        "Fixed_wage_amount": null,
        "Category": "MOBILE",
        "Brand": null,
        "Model": null,
        "SaleChannel": "USED_DEVICE",
        "CalculationType": "40"
      }
    ]
  }
}
```

## What we sell in BUNDLE journey?

```json
{
  "Service": "Electronic Equipments Insurance",
  "SaleChannel": "BUNDLED",
  "Template": {
    "Template_name": "premium",
    "Duration": 60,
    "Wage_percent": 0.025,
    "Max_compensation_amount": null,
    "Include_tax": true,
    "Active_to": null,
    "Active_from": null,
    "Coverages": [
      {
        "Title": "پوشش سهل انگاری",
        "Cover_taxonomy_key": "Irresponsibility",
        "Cover_taxonomy_title": "سهل انگاری",
        "Is_total_lost": false
      },
      {
        "Title": "پوشش سخت افزاری",
        "Cover_taxonomy_key": "Hardware",
        "Cover_taxonomy_title": "سخت افزاری",
        "Is_total_lost": false
      },
      {
        "Title": "پوشش آتش سوزی",
        "Cover_taxonomy_key": "Fire",
        "Cover_taxonomy_title": "آتش سوزی",
        "Is_total_lost": false
      },
      {
        "Title": "پوشش بلایای طبیعی",
        "Cover_taxonomy_key": "Disaster",
        "Cover_taxonomy_title": "بلایای طبیعی",
        "Is_total_lost": false
      },
      {
        "Title": "نرخ بازگشت خسارت",
        "Cover_taxonomy_key": null,
        "Cover_taxonomy_title": null,
        "Is_total_lost": false
      },
      {
        "Title": "پوشش ضرب خودرگی",
        "Cover_taxonomy_key": "Damage",
        "Cover_taxonomy_title": "ضربه و آسیب",
        "Is_total_lost": false
      },
      {
        "Title": "بیمه دزدی با شکست حرز",
        "Cover_taxonomy_key": "Stealing",
        "Cover_taxonomy_title": "سرقت",
        "Is_total_lost": false
      },
      {
        "Title": "پوشش آتش سوزی",
        "Cover_taxonomy_key": "Fire",
        "Cover_taxonomy_title": "آتش سوزی",
        "Is_total_lost": false
      },
      {
        "Title": "پوشش آب خودرگی",
        "Cover_taxonomy_key": "Water",
        "Cover_taxonomy_title": "نفوذ مایعات",
        "Is_total_lost": false
      }
    ],
    "Pricing": [
      {
        "Max_value": null,
        "Min_value": null,
        "Wage_percent": 0.01,
        "Fixed_wage_amount": null,
        "Category": "MOBILE",
        "Brand": null,
        "Model": null,
        "SaleChannel": "BUNDLED",
        "CalculationType": "40"
      },
      {
        "Max_value": null,
        "Min_value": null,
        "Wage_percent": 0.01,
        "Fixed_wage_amount": null,
        "Category": "TABLET",
        "Brand": null,
        "Model": null,
        "SaleChannel": "BUNDLED",
        "CalculationType": "40"
      },
      {
        "Max_value": null,
        "Min_value": null,
        "Wage_percent": 0.01,
        "Fixed_wage_amount": null,
        "Category": "LAPTOP",
        "Brand": null,
        "Model": null,
        "SaleChannel": "BUNDLED",
        "CalculationType": "40"
      }
    ]
  }
}
```